namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(3, 5, 8)]
        [TestCase(-10, 5, -5)]
        [TestCase(0, 0, 0)]
        public void Add_WhenGivenNumbers_ReturnsCorrectResult(int a, int b, int expectedResult)
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
