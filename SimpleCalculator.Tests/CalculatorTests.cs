namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenGivenTwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(3, 5);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Add_WhenGivenNegativeAndPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(-10, 5);

            // Assert
            Assert.AreEqual(-5, result);
        }
    }
}
