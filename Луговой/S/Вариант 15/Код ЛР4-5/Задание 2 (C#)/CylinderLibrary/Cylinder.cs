using System;


namespace CylinderLibrary
{
    /// <summary>
    /// Журнал вызовов. Вынесен в интерфейс, чтобы в тестах его можно было
    /// заменить мок-объектом и проверить, что логирование выполняется.
    /// </summary>
    public interface ICallLogger
    {
        void Info(string message);
        void Error(string message);
    }

    /// <summary>Журнал, выводящий записи в консоль.</summary>
    public sealed class ConsoleCallLogger : ICallLogger
    {
        public void Info(string message) => Console.WriteLine("INFO: " + message);

        public void Error(string message) => Console.WriteLine("ERROR: " + message);
    }

    /// <summary>
    /// Задание 2, вариант 15: «Логирование вызовов».
    /// Вычисление объёма цилиндра V = pi * r^2 * h с записью в журнал
    /// аргументов и результата каждого вызова.
    /// </summary>
    public sealed class CylinderCalculator
    {
        private readonly ICallLogger _logger;

        public CylinderCalculator(ICallLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Вычисляет объём цилиндра по радиусу основания и высоте.
        /// Каждый вызов логируется: сначала аргументы, затем результат;
        /// при некорректных аргументах в журнал пишется причина отказа.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Аргумент не является конечным числом (NaN или бесконечность).
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Аргумент отрицателен.
        /// </exception>
        public double CalculateVolume(double radius, double height)
        {
            _logger.Info(FormattableString.Invariant(
                $"call CalculateVolume(radius={radius}, height={height})"));

            Validate(nameof(radius), radius);
            Validate(nameof(height), height);

            double volume = Math.PI * radius * radius * height;

            _logger.Info(FormattableString.Invariant(
                $"result CalculateVolume = {volume}"));
            return volume;
        }

        private void Validate(string name, double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                _logger.Error(FormattableString.Invariant(
                    $"invalid value of {name}: {value}"));
                throw new ArgumentException($"{name} must be a finite number", name);
            }

            if (value < 0)
            {
                _logger.Error(FormattableString.Invariant(
                    $"negative {name}: {value}"));
                throw new ArgumentOutOfRangeException(name, value,
                    $"{name} must not be negative");
            }
        }
    }
}
