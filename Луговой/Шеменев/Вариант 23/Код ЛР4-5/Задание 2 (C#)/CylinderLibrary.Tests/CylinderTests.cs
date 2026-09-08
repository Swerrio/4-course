using System;
using CylinderLibrary;

namespace CylinderLibrary.Tests
{
    // ===================================================================
    // Блок 1. Правильность вычислений на положительных числах
    // ===================================================================
    [TestClass]
    public class VolumePositiveNumbersTests
    {
        [TestMethod]
        [Description("radius = 1, height = 1 -> pi")]
        public void Volume_1and1_ReturnsPi()
        {
            Assert.AreEqual(Math.PI, Cylinder.CalculateVolume(1, 1), 1e-12);
        }

        [TestMethod]
        [Description("radius = 3, height = 5 -> 141.3716694115407")]
        public void Volume_3and5_Returned()
        {
            Assert.AreEqual(141.3716694115407,
                            Cylinder.CalculateVolume(3, 5), 1e-10);
        }

        [TestMethod]
        [Description("radius = 2, height = 10 -> 125.66370614359172")]
        public void Volume_2and10_Returned()
        {
            Assert.AreEqual(125.66370614359172,
                            Cylinder.CalculateVolume(2, 10), 1e-10);
        }

        [TestMethod]
        [Description("Дробные аргументы: radius = 2.5, height = 3.7")]
        public void Volume_Fractional_Returned()
        {
            Assert.AreEqual(72.64933011426398,
                            Cylinder.CalculateVolume(2.5, 3.7), 1e-10);
        }

        [TestMethod]
        [Description("Результат совпадает с эталонной формулой pi * r^2 * h")]
        [DataRow(1.0, 2.0)]
        [DataRow(4.0, 0.5)]
        [DataRow(7.25, 11.5)]
        [DataRow(0.1, 0.2)]
        public void Volume_MatchesReferenceFormula(double radius, double height)
        {
            double expected = Math.PI * radius * radius * height;

            Assert.AreEqual(expected, Cylinder.CalculateVolume(radius, height),
                            1e-12);
        }
    }

    // ===================================================================
    // Блок 2. Проверка заданной точности вычислений
    // ===================================================================
    [TestClass]
    public class VolumePrecisionTests
    {
        [TestMethod]
        [Description("Абсолютная погрешность не превышает 1e-9")]
        public void Volume_PrecisionWithinDelta()
        {
            Assert.AreEqual(17.671458676442586,
                            Cylinder.CalculateVolume(1.5, 2.5), 1e-9);
        }

        [TestMethod]
        [Description("Малые значения: radius = 1e-3, height = 1e-3")]
        public void Volume_SmallValues()
        {
            Assert.AreEqual(Math.PI * 1e-9,
                            Cylinder.CalculateVolume(1e-3, 1e-3), 1e-18);
        }

        [TestMethod]
        [Description("Большие значения: radius = 1e5, height = 1e5")]
        public void Volume_LargeValues()
        {
            Assert.AreEqual(Math.PI * 1e15,
                            Cylinder.CalculateVolume(1e5, 1e5), 1.0);
        }

        [TestMethod]
        [Description("Объём конечен и положителен")]
        public void Volume_IsFiniteAndPositive()
        {
            double volume = Cylinder.CalculateVolume(3, 5);

            Assert.IsFalse(double.IsNaN(volume));
            Assert.IsFalse(double.IsInfinity(volume));
            Assert.IsGreaterThan(0.0, volume);
        }

        [TestMethod]
        [Description("Объём равен площади основания, умноженной на высоту")]
        public void Volume_EqualsBaseAreaTimesHeight()
        {
            Assert.AreEqual(Cylinder.CalculateBaseArea(4) * 6,
                            Cylinder.CalculateVolume(4, 6), 1e-12);
        }
    }

    // ===================================================================
    // Блок 3. Реакция на некорректные входные данные
    // ===================================================================
    [TestClass]
    public class VolumeInvalidInputTests
    {
        [TestMethod]
        [Description("Нулевой радиус вызывает ArgumentOutOfRangeException")]
        public void Volume_ZeroRadius_Throws()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Cylinder.CalculateVolume(0, 5));
        }

        [TestMethod]
        [Description("Отрицательная высота вызывает ArgumentOutOfRangeException")]
        public void Volume_NegativeHeight_Throws()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Cylinder.CalculateVolume(3, -5));
        }

        [TestMethod]
        [Description("Аргумент NaN вызывает ArgumentException")]
        public void Volume_NaN_Throws()
        {
            Assert.ThrowsExactly<ArgumentException>(
                () => Cylinder.CalculateVolume(double.NaN, 5));
        }

        [TestMethod]
        [Description("Бесконечность вызывает ArgumentException")]
        public void Volume_Infinity_Throws()
        {
            Assert.ThrowsExactly<ArgumentException>(
                () => Cylinder.CalculateVolume(3, double.PositiveInfinity));
        }

        [TestMethod]
        [Description("Площадь основания также контролирует аргумент")]
        public void BaseArea_ZeroRadius_Throws()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => Cylinder.CalculateBaseArea(0));
        }
    }
}
