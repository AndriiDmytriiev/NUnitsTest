
using NUnit.Framework;
using NUnitsTest;



namespace NUnitsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorTests calculatorTest = new CalculatorTests();

            calculatorTest.Add_ShouldReturnCorrectSum();
            calculatorTest.Subtract_ShouldReturnCorrectDifference();
            calculatorTest.Multiply_ShouldReturnCorrectProduct();
            calculatorTest.Divide_ShouldReturnCorrectQuotient();
        }
       
    }

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
            Console.WriteLine("Add Result is :" + result.ToString());
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Subtract(5, 3);

            // Assert
            Assert.AreEqual(2, result);
            Console.WriteLine("Subtract Result is :" + result.ToString());
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Multiply(2, 3);

            // Assert
            Assert.AreEqual(6, result);
            Console.WriteLine("Multiply Result is :" + result.ToString());
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Divide(6, 2);

            // Assert
            Assert.AreEqual(3, result);
            Console.WriteLine("Divide Result is :" + result.ToString());
        }
    }
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.", nameof(b));
            }

            return (double)a / b;
        }
    }

}