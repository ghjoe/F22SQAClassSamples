using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Add(1, 1);

            // Assert
            Assert.IsTrue(result == 2, "AddTest failed, 1 + 1 did not equal 2.");

        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act + Assert
            Assert.ThrowsException<ArgumentException>(() => myCalculator.Divide(10, 0), "Divide by zero did not cause an ArgumentException");
        }

        [TestMethod]
        public void DivideByOneTest()
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Divide(1, 1);

            // Assert
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Multiply(10, 1);

            // Assert
            Assert.IsTrue(result == 10);
        }
    }
}