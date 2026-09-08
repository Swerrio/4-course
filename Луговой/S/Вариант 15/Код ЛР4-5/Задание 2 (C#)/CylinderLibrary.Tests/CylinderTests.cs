using System;
using System.Globalization;
using CylinderLibrary;
using Moq;

namespace CylinderLibrary.Tests
{
    // ===================================================================
    // Блок 1. Корректность вычислений
    // ===================================================================
    [TestClass]
    public class VolumeCalculationTests
    {
        private CylinderCalculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            // для этого блока журнал не проверяется, достаточно пустого мока
            _calculator = new CylinderCalculator(Mock.Of<ICallLogger>());
        }

        [TestMethod]
        [Description("Объём при radius = 3, height = 5 равен pi * 9 * 5")]
        public void Volume_3and5_Returned()
        {
            double actual = _calculator.CalculateVolume(3, 5);

            Assert.AreEqual(Math.PI * 9 * 5, actual, 1e-10);
        }

        [TestMethod]
        [Description("Дробные аргументы: radius = 2.5, height = 3.7")]
        public void Volume_FractionalArguments_Returned()
        {
            double actual = _calculator.CalculateVolume(2.5, 3.7);

            Assert.AreEqual(Math.PI * 2.5 * 2.5 * 3.7, actual, 1e-10);
        }

        [TestMethod]
        [Description("Нулевая высота даёт нулевой объём")]
        public void Volume_ZeroHeight_ReturnsZero()
        {
            Assert.AreEqual(0.0, _calculator.CalculateVolume(5, 0), 1e-12);
        }

        [TestMethod]
        [Description("Отрицательный радиус вызывает ArgumentOutOfRangeException")]
        public void Volume_NegativeRadius_Throws()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => _calculator.CalculateVolume(-1, 5));
        }

        [TestMethod]
        [Description("Аргумент NaN вызывает ArgumentException")]
        public void Volume_NaNArgument_Throws()
        {
            Assert.ThrowsExactly<ArgumentException>(
                () => _calculator.CalculateVolume(double.NaN, 5));
        }
    }

    // ===================================================================
    // Блок 2. Проверка логирования вызовов с помощью моков
    // ===================================================================
    [TestClass]
    public class CallLoggingTests
    {
        private Mock<ICallLogger> _logger;
        private CylinderCalculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _logger = new Mock<ICallLogger>();
            _calculator = new CylinderCalculator(_logger.Object);
        }

        [TestMethod]
        [Description("При успешном вызове Info вызывается ровно дважды")]
        public void Info_CalledTwice_OnSuccess()
        {
            _calculator.CalculateVolume(3, 5);

            _logger.Verify(l => l.Info(It.IsAny<string>()), Times.Exactly(2));
        }

        [TestMethod]
        [Description("Первая запись журнала содержит переданные аргументы")]
        public void Arguments_AreLogged()
        {
            _calculator.CalculateVolume(2, 4);

            _logger.Verify(l => l.Info("call CalculateVolume(radius=2, height=4)"),
                           Times.Once);
        }

        [TestMethod]
        [Description("Вторая запись журнала содержит фактический результат")]
        public void Result_IsLogged()
        {
            double expected = Math.PI * 2 * 2 * 4;

            _calculator.CalculateVolume(2, 4);

            _logger.Verify(l => l.Info("result CalculateVolume = "
                              + expected.ToString(CultureInfo.InvariantCulture)),
                           Times.Once);
        }

        [TestMethod]
        [Description("Отрицательный аргумент пишется в журнал как ошибка")]
        public void Error_IsLogged_ForNegativeArgument()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => _calculator.CalculateVolume(3, -5));

            _logger.Verify(l => l.Error("negative height: -5"), Times.Once);
        }

        [TestMethod]
        [Description("Некорректное значение пишется в журнал как ошибка")]
        public void Error_IsLogged_ForNaNArgument()
        {
            Assert.ThrowsExactly<ArgumentException>(
                () => _calculator.CalculateVolume(double.NaN, 5));

            _logger.Verify(l => l.Error("invalid value of radius: NaN"), Times.Once);
        }

        [TestMethod]
        [Description("После ошибки результат в журнал не пишется")]
        public void Result_NotLogged_AfterError()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => _calculator.CalculateVolume(-1, 5));

            _logger.Verify(l => l.Info(It.IsAny<string>()), Times.Once);
            _logger.Verify(l => l.Info(It.Is<string>(s => s.StartsWith("result"))),
                           Times.Never);
        }

        [TestMethod]
        [Description("Порядок записей: сначала аргументы, затем результат")]
        public void LogOrder_ArgumentsThenResult()
        {
            var sequence = new MockSequence();
            var ordered = new Mock<ICallLogger>(MockBehavior.Strict);
            ordered.InSequence(sequence).Setup(l => l.Info(It.Is<string>(
                s => s.StartsWith("call"))));
            ordered.InSequence(sequence).Setup(l => l.Info(It.Is<string>(
                s => s.StartsWith("result"))));

            new CylinderCalculator(ordered.Object).CalculateVolume(1, 1);

            ordered.VerifyAll();
        }
    }
}
