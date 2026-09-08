using System.Collections.Generic;
using OrderSystem;

namespace OrderSystem.Tests
{
    // ===================================================================
    // Часть 1. Интеграция «снизу-вверх»: нижние модули заменены заглушками
    // ===================================================================
    [TestClass]
    public class IntegrationWithStubsTests
    {
        private OrderValidator _validator;
        private InventoryManagerStub _inventory;
        private PaymentProcessorStub _payment;
        private OrderService _service;

        [TestInitialize]
        public void SetUp()
        {
            _validator = new OrderValidator();
            _inventory = new InventoryManagerStub();
            _payment = new PaymentProcessorStub();
            _service = new OrderService(_validator, _inventory, _payment);
        }

        [TestMethod]
        [Description("IT-1. Успешное создание и оплата заказа (123, 55, 2, 100.0)")]
        public void IT1_HappyPath_OkReturned()
        {
            var result = _service.PlaceOrder(123, 55, 2, 100.0);

            Assert.AreEqual(OrderResult.Ok, result);
            CollectionAssert.Contains(_inventory.Calls, "UpdateStock(55, 2)");
            CollectionAssert.Contains(_payment.Calls, "ProcessPayment(123, 100)");
        }

        [TestMethod]
        [Description("IT-2. Невалидный ID товара (124, 999, 1, 50.0)")]
        public void IT2_InvalidItem_ValidationFailed()
        {
            var result = _service.PlaceOrder(124, 999, 1, 50.0);

            Assert.AreEqual(OrderResult.ValidationFailed, result);
            // после отказа валидации нижние модули вызываться не должны
            Assert.IsEmpty(_inventory.Calls);
            Assert.IsEmpty(_payment.Calls);
        }

        [TestMethod]
        [Description("IT-3. Количество больше остатка (125, 55, 999, 500.0)")]
        public void IT3_QuantityOverStock_StockFailed()
        {
            var result = _service.PlaceOrder(125, 55, 999, 500.0);

            Assert.AreEqual(OrderResult.StockFailed, result);
            CollectionAssert.Contains(_inventory.Calls, "UpdateStock(55, 999)");
            Assert.IsEmpty(_payment.Calls);
        }

        [TestMethod]
        [Description("IT-4. Валидный заказ, ошибка оплаты (126, 55, 1, 100.0)")]
        public void IT4_PaymentDeclined_PaymentFailed()
        {
            var result = _service.PlaceOrder(126, 55, 1, 100.0);

            Assert.AreEqual(OrderResult.PaymentFailed, result);
            CollectionAssert.Contains(_payment.Calls, "ProcessPayment(126, 100)");
        }
    }

    // ===================================================================
    // Часть 2. Интеграция реальных модулей, заглушки не используются
    // ===================================================================
    [TestClass]
    public class IntegrationRealTests
    {
        private InventoryManager _inventory;
        private OrderService _service;

        [TestInitialize]
        public void SetUp()
        {
            _inventory = new InventoryManager();
            _service = new OrderService(new OrderValidator(), _inventory,
                                        new PaymentProcessor());
        }

        [TestMethod]
        [Description("IT-1r. После успешного заказа остаток уменьшается на 2")]
        public void IT1r_StockDecreased()
        {
            var before = _inventory.GetStock(55);

            Assert.AreEqual(OrderResult.Ok, _service.PlaceOrder(123, 55, 2, 100.0));
            Assert.AreEqual(before - 2, _inventory.GetStock(55));
        }

        [TestMethod]
        [Description("IT-4r. При отказе оплаты товар должен вернуться на склад")]
        public void IT4r_RollbackAfterPaymentError()
        {
            var before = _inventory.GetStock(55);

            var result = _service.PlaceOrder(126, 55, 1, 100.0);

            Assert.AreEqual(OrderResult.PaymentFailed, result);
            Assert.AreEqual(before, _inventory.GetStock(55),
                "Товар не возвращён на склад после неуспешной оплаты");
        }

        [TestMethod]
        [Description("IT-5. Заказ с нулевым количеством (127, 55, 0, 0.0)")]
        public void IT5_ZeroQuantity_ValidationFailed()
        {
            var before = _inventory.GetStock(55);

            Assert.AreEqual(OrderResult.ValidationFailed,
                            _service.PlaceOrder(127, 55, 0, 0.0));
            Assert.AreEqual(before, _inventory.GetStock(55));
        }

        [TestMethod]
        [Description("IT-6. Заказ с отрицательным количеством (128, 77, -1, 10.0)")]
        public void IT6_NegativeQuantity_ValidationFailed()
        {
            var before = _inventory.GetStock(77);

            Assert.AreEqual(OrderResult.ValidationFailed,
                            _service.PlaceOrder(128, 77, -1, 10.0));
            Assert.AreEqual(before, _inventory.GetStock(77));
        }

        [TestMethod]
        [Description("IT-7. Повторная обработка уже оплаченного заказа 123")]
        public void IT7_RepeatedOrder_StockChargedOnce()
        {
            Assert.AreEqual(OrderResult.Ok, _service.PlaceOrder(123, 55, 2, 100.0));
            var afterFirst = _inventory.GetStock(55);

            _service.PlaceOrder(123, 55, 2, 100.0);

            Assert.AreEqual(afterFirst, _inventory.GetStock(55),
                "Повторная обработка заказа списала товар второй раз");
        }

        [TestMethod]
        [Description("IT-8. Несуществующий orderId (999, 55, 1, 100.0)")]
        public void IT8_UnknownOrder_ValidationFailed()
        {
            var before = _inventory.GetStock(55);

            Assert.AreEqual(OrderResult.ValidationFailed,
                            _service.PlaceOrder(999, 55, 1, 100.0));
            Assert.AreEqual(before, _inventory.GetStock(55));
        }
    }
}
