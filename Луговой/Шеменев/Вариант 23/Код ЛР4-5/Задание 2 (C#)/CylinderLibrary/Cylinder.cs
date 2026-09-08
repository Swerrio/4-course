using System;

namespace CylinderLibrary
{
    /// <summary>
    /// Задание 2, вариант 23 -> вариант 1 «Базовая реализация»
    /// (в перечне заданий 22 варианта, номер отображён циклически: 23 - 22 = 1).
    ///
    /// Вычисление объёма цилиндра для положительных чисел: V = pi * r^2 * h.
    /// </summary>
    public static class Cylinder
    {
        /// <summary>
        /// Вычисляет объём цилиндра по радиусу основания и высоте.
        /// </summary>
        /// <param name="radius">Радиус основания, положительное число.</param>
        /// <param name="height">Высота цилиндра, положительное число.</param>
        /// <returns>Объём цилиндра.</returns>
        /// <exception cref="ArgumentException">
        /// Аргумент не является конечным числом (NaN или бесконечность).
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Аргумент меньше или равен нулю.
        /// </exception>
        public static double CalculateVolume(double radius, double height)
        {
            EnsurePositive(nameof(radius), radius);
            EnsurePositive(nameof(height), height);

            return Math.PI * radius * radius * height;
        }

        /// <summary>Площадь основания цилиндра: S = pi * r^2.</summary>
        public static double CalculateBaseArea(double radius)
        {
            EnsurePositive(nameof(radius), radius);

            return Math.PI * radius * radius;
        }

        private static void EnsurePositive(string name, double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentException($"{name} must be a finite number", name);

            if (value <= 0)
                throw new ArgumentOutOfRangeException(name, value,
                    $"{name} must be positive");
        }
    }
}
