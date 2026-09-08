using System.Collections.Generic;
using OrderSystem;

namespace OrderSystem.Tests
{
    /// <summary>
    /// Заглушка (Stub) для InventoryManager.
    /// По условию шага 3 задания:
    ///   UpdateStock(55, 2)   -> true
    ///   UpdateStock(55, 999) -> false
    /// Остальные комбинации контрактом заглушки не предусмотрены -> false.
    /// </summary>
    public sealed class InventoryManagerStub : IInventoryManager
    {
        private static readonly Dictionary<(int, int), bool> Responses = new()
        {
            { (55, 1), true },    // добавлено: сценарий IT-4 использует заказ 126
            { (55, 2), true },
            { (55, 999), false },
        };

        public List<string> Calls { get; } = new List<string>();

        public bool UpdateStock(int itemId, int quantity)
        {
            Calls.Add($"UpdateStock({itemId}, {quantity})");
            return Responses.TryGetValue((itemId, quantity), out var result) && result;
        }

        public bool RestoreStock(int itemId, int quantity)
        {
            Calls.Add($"RestoreStock({itemId}, {quantity})");
            return true;
        }
    }

    /// <summary>
    /// Заглушка (Stub) для PaymentProcessor.
    /// По условию шага 3 задания:
    ///   ProcessPayment(123, 100.0) -> true
    ///   ProcessPayment(126, 100.0) -> false
    /// </summary>
    public sealed class PaymentProcessorStub : IPaymentProcessor
    {
        private static readonly Dictionary<(int, double), bool> Responses = new()
        {
            { (123, 100.0), true },
            { (126, 100.0), false },
        };

        public List<string> Calls { get; } = new List<string>();

        public bool ProcessPayment(int orderId, double amount)
        {
            Calls.Add($"ProcessPayment({orderId}, {amount})");
            return Responses.TryGetValue((orderId, amount), out var result) && result;
        }
    }
}
