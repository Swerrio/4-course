using OrderSystem;

namespace OrderSystem.Tests
{
    /// <summary>
    /// Проверка предложенных исправлений.
    /// Дефект № 1 — при отказе оплаты товар не возвращается на склад.
    ///              Исправление: rollback = true.
    /// Дефект № 2 — сумма платежа не сверяется со стоимостью заказа.
    ///              Исправление: strictAmount = true.
    /// </summary>
    [TestClass]
    public class FixedBehaviourTests
    {
        private InventoryManager _inventory;
        private OrderService _service;

        [TestInitialize]
        public void SetUp()
        {
            _inventory = new InventoryManager();
            _service = new OrderService(new OrderValidator(), _inventory,
                                        new PaymentProcessor(),
                                        rollback: true, strictAmount: true);
        }

        [TestMethod]
        [Description("IT-4r (после исправления). Товар возвращается на склад")]
        public void IT4r_RollbackAfterPaymentError()
        {
            var before = _inventory.GetStock(55);

            Assert.AreEqual(OrderResult.PaymentFailed,
                            _service.PlaceOrder(126, 55, 1, 100.0));
            Assert.AreEqual(before, _inventory.GetStock(55));
        }

        [TestMethod]
        [Description("IT-7 (после исправления). Заниженная сумма отклоняется")]
        public void IT7_AmountLessThanOrderCost_Mismatch()
        {
            var before = _inventory.GetStock(55);

            Assert.AreEqual(OrderResult.AmountMismatch,
                            _service.PlaceOrder(129, 55, 2, 1.0));
            Assert.AreEqual(before, _inventory.GetStock(55));
        }

        [TestMethod]
        [Description("Регрессия: основной сценарий IT-1 не нарушен")]
        public void Regression_HappyPath()
        {
            var before = _inventory.GetStock(55);

            Assert.AreEqual(OrderResult.Ok, _service.PlaceOrder(123, 55, 2, 100.0));
            Assert.AreEqual(before - 2, _inventory.GetStock(55));
        }
    }
}
