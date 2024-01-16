using SimpleCalculator;

namespace CalculatorTests_MSTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Addition_InputIs2and5_Returns7()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 5);
            Assert.AreEqual(7, result);
        }
    }
}