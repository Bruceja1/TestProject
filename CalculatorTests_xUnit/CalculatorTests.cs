using Microsoft.Extensions.Configuration;
using SimpleCalculator;


namespace CalculatorTests_xUnit
{
    public class CalculatorTests
    {
        [Theory]
        [TestDataFromFile(@"../../../Data/testdata.txt")]  
        public void Add_WhenGivenNumbers_ReturnsCorrectResult(int a, int b, int expectedResult)
        {

            Calculator calculator = new Calculator();

            int result = calculator.Add(a, b);

            Assert.Equal(expectedResult, result);
        }
    }
}
