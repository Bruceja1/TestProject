using SimpleCalculator;

namespace CalculatorTests_xUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_WhenGivenTwoPositiveNumbers_ReturnsCorrectResult()
        {          
            Calculator calculator = new Calculator();

            int result = calculator.Add(3, 5);

            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_WhenGivenNegativeAndPositiveNumbers_ReturnsCorrectResult()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(-10, 5);

            Assert.Equal(-5, result);
        }
    }
}
