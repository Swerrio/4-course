using System;
using System.Collections.Generic;

namespace OrderSystem
{
    /// <summary>Данные заказа: товар, количество, стоимость.</summary>
    public sealed class Order
    {
        public Order(int itemId, int quantity, double amount)
        {
            ItemId = itemId;
            Quantity = quantity;
            Amount = amount;
        }

        public int ItemId { get; }
        public int Quantity { get; }
        public double Amount { get; }
    }

    /// <summary>Тестовые данные предметной области.</summary>
    public static class TestData
    {
        // Каталог товаров: itemId -> название
        public static Dictionary<int, string> Catalog() => new Dictionary<int, string>
        {
            { 55, "Клавиатура механическая" },
            { 77, "Мышь беспроводная" },
        };

        // Остатки на складе: itemId -> количество
        public static Dictionary<int, int> Stock() => new Dictionary<int, int>
        {
            { 55, 10 },
            { 77, 3 },
        };

        // Заказы: orderId -> данные заказа
        public static Dictionary<int, Order> Orders() => new Dictionary<int, Order>
        {
            { 123, new Order(55, 2, 100.0) },
            { 124, new Order(999, 1, 50.0) },    // несуществующий товар
            { 125, new Order(55, 999, 500.0) },  // количество больше остатка
            { 126, new Order(55, 1, 100.0) },    // недостаточно средств
            { 127, new Order(77, 3, 150.0) },    // количество равно остатку
            { 128, new Order(77, 3, 150.0) },    // повторный заказ на весь остаток
            { 129, new Order(55, 2, 100.0) },    // проверка соответствия суммы
            { 130, new Order(55, 1, 0.0) },      // нулевая стоимость заказа
        };

        // Доступные средства по заказу: orderId -> сумма на счёте клиента
        public static Dictionary<int, double> Accounts() => new Dictionary<int, double>
        {
            { 123, 5000.0 },
            { 124, 5000.0 },
            { 125, 5000.0 },
            { 126, 50.0 },   // средств меньше, чем сумма заказа (100.0)
            { 127, 5000.0 },
            { 128, 5000.0 },
            { 129, 5000.0 },
            { 130, 5000.0 },
        };
    }

    // -------------------------------------------------------------------
    // Контракты модулей: позволяют подставлять заглушки вместо реализаций
    // -------------------------------------------------------------------
    public interface IInventoryManager
    {
        bool UpdateStock(int itemId, int quantity);
        bool RestoreStock(int itemId, int quantity);
    }

    public interface IPaymentProcessor
    {
        bool ProcessPayment(int orderId, double amount);
    }

    public interface IOrderValidator
    {
        bool ValidateOrder(int orderId);
        Order GetOrder(int orderId);
    }

    // -------------------------------------------------------------------
    // Модуль 1. InventoryManager — обновление количества товара на складе
    // -------------------------------------------------------------------
    public sealed class InventoryManager : IInventoryManager
    {
        private readonly Dictionary<int, int> _stock;

        public InventoryManager(Dictionary<int, int> stock = null)
        {
            _stock = stock ?? TestData.Stock();
        }

        public int GetStock(int itemId) =>
            _stock.TryGetValue(itemId, out var value) ? value : 0;

        /// <summary>Списывает quantity единиц товара. true — остаток обновлён.</summary>
        public bool UpdateStock(int itemId, int quantity)
        {
            if (!_stock.ContainsKey(itemId)) return false;
            if (quantity <= 0) return false;
            if (_stock[itemId] < quantity) return false;

            _stock[itemId] -= quantity;
            return true;
        }

        /// <summary>Компенсирующая операция: возврат товара на склад.</summary>
        public bool RestoreStock(int itemId, int quantity)
        {
            if (!_stock.ContainsKey(itemId)) return false;
            _stock[itemId] += quantity;
            return true;
        }
    }

    // -------------------------------------------------------------------
    // Модуль 2. PaymentProcessor — имитация оплаты заказа
    // -------------------------------------------------------------------
    public sealed class PaymentProcessor : IPaymentProcessor
    {
        private readonly Dictionary<int, double> _accounts;

        public PaymentProcessor(Dictionary<int, double> accounts = null)
        {
            _accounts = accounts ?? TestData.Accounts();
        }

        /// <summary>true — оплата прошла успешно.</summary>
        public bool ProcessPayment(int orderId, double amount)
        {
            if (!_accounts.ContainsKey(orderId)) return false;
            if (amount <= 0) return false;
            if (_accounts[orderId] < amount) return false;

            _accounts[orderId] -= amount;
            return true;
        }
    }

    // -------------------------------------------------------------------
    // Модуль 3. OrderValidator — проверка корректности данных заказа
    // -------------------------------------------------------------------
    public sealed class OrderValidator : IOrderValidator
    {
        private readonly Dictionary<int, Order> _orders;
        private readonly Dictionary<int, string> _catalog;

        public OrderValidator(Dictionary<int, Order> orders = null,
                              Dictionary<int, string> catalog = null)
        {
            _orders = orders ?? TestData.Orders();
            _catalog = catalog ?? TestData.Catalog();
        }

        /// <summary>true — заказ корректен.</summary>
        public bool ValidateOrder(int orderId)
        {
            if (!_orders.TryGetValue(orderId, out var order)) return false;
            if (!_catalog.ContainsKey(order.ItemId)) return false;
            if (order.Quantity <= 0) return false;
            if (order.Amount <= 0) return false;
            return true;
        }

        public Order GetOrder(int orderId) =>
            _orders.TryGetValue(orderId, out var order) ? order : null;
    }

    /// <summary>Коды результата обработки заказа.</summary>
    public static class OrderResult
    {
        public const string Ok = "OK";
        public const string ValidationFailed = "VALIDATION_FAILED";
        public const string StockFailed = "STOCK_FAILED";
        public const string PaymentFailed = "PAYMENT_FAILED";
        public const string AmountMismatch = "AMOUNT_MISMATCH";
    }

    // -------------------------------------------------------------------
    // Интегрирующий модуль: валидация -> списание со склада -> оплата
    // -------------------------------------------------------------------
    public sealed class OrderService
    {
        private readonly IOrderValidator _validator;
        private readonly IInventoryManager _inventory;
        private readonly IPaymentProcessor _payment;

        /// <remarks>
        /// rollback = false и strictAmount = false соответствуют текущей
        /// (исследуемой) версии системы: компенсирующая транзакция не
        /// реализована, сумма платежа с расчётной стоимостью заказа
        /// не сверяется.
        /// </remarks>
        public OrderService(IOrderValidator validator,
                            IInventoryManager inventory,
                            IPaymentProcessor payment,
                            bool rollback = false,
                            bool strictAmount = false)
        {
            _validator = validator;
            _inventory = inventory;
            _payment = payment;
            Rollback = rollback;
            StrictAmount = strictAmount;
        }

        public bool Rollback { get; }
        public bool StrictAmount { get; }

        public string PlaceOrder(int orderId, int itemId, int quantity, double amount)
        {
            if (!_validator.ValidateOrder(orderId))
                return OrderResult.ValidationFailed;

            if (StrictAmount)
            {
                var expected = _validator.GetOrder(orderId).Amount;
                if (Math.Abs(amount - expected) > 1e-9)
                    return OrderResult.AmountMismatch;
            }

            if (!_inventory.UpdateStock(itemId, quantity))
                return OrderResult.StockFailed;

            if (!_payment.ProcessPayment(orderId, amount))
            {
                if (Rollback)
                    _inventory.RestoreStock(itemId, quantity);
                return OrderResult.PaymentFailed;
            }

            return OrderResult.Ok;
        }
    }
}
