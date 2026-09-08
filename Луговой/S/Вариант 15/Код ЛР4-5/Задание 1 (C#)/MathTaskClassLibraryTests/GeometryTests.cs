using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // arrange: исходные данные и ожидаемый результат
            int a = 3;
            int b = 5;
            int expected = 15;
            var geometry = new Geometry();

            // act: вычисление с помощью тестируемого метода
            int actual = geometry.RectangleArea(a, b);

            // assert: сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
