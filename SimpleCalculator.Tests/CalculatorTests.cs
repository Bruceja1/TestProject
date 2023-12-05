namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }
        
        [Test]
        [TestCase(3, 5, 8)]
        [TestCase(-10, 5, -5)]
        [TestCase(0, 0, 0)]
        public void Add_WhenGivenNumbers_ReturnsCorrectResult(int a, int b, int expectedResult)
        {
            int result = calculator.Add(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(7, 2, 5)]
        [TestCase(16, -7, 23)]
        [TestCase(0, 4, -4)]
        public void Subtract_WhenGivenNumbers_ReturnsCorrectResult(int a, int b, int expectedResult)
        {
            int result = calculator.Subtract(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
