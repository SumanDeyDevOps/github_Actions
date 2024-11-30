using NUnit.Framework;
using TestOne;

namespace TestOne
{
    [TestFixture] // Marks this class as containing NUnit tests
    public class CalculatorTests
    {
        private Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator(); // Initialize here
        }

        [SetUp] // Runs before each test
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test] // Marks this method as a test case
        public void Add_WhenCalled_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifference()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsValue()
        {
            // Arrange
            int a = 3;
            int b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Division_WhenCalled_ReturnsValue()
        {
            // Arrange
            int a = 9;
            int b = 3;

            // Act
            int result = _calculator.Divison(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }
    }
}