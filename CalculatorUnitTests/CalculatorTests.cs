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

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(100, 10, 10)]
        [DataRow(10000, 100, 100)]
        [DataRow(1000, 10, 100)]
        [DataRow(1000000, 1000, 1000)]
        public void DivideByPowersOfTenTest(int operand1, int operand2, int expectedResult)
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Divide(operand1, operand2);

            // Assert
            Assert.IsTrue(result == expectedResult);
        }

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.csv", @".\\CalculatorTestData.csv", "Row", DataAccessMethod.Sequential)]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", ".\\CalculatorTestData.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", ".\\CalculatorTestData.csv", DataAccessMethod.Sequential]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", ".\\data.csv", "data#csv",   DataAccessMethod.Sequential), TestMethod]
        public void DivideByPowersOfTenTestUsingDataFile(int operand1, int operand2, int expectedResult)
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Divide(operand1, operand2);

            // Assert
            Assert.IsTrue(result == expectedResult);
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
        public void DivideByTenTest()
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Divide(100, 10);

            // Assert
            Assert.IsTrue(result == 10);
        }

        [TestMethod]
        public void DivideByHundredTest()
        {
            // Arrange
            BasicCalculator myCalculator = new BasicCalculator();

            // Act
            int result = myCalculator.Divide(10000, 100);

            // Assert
            Assert.IsTrue(result == 100);
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