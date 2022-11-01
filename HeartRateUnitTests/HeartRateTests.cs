using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeartRate;

namespace HeartRateUnitTests
{
    [TestClass]
    public class HeartRateTests
    {
        [TestMethod]
        public void Female30ActiveHigh()
        {
            // Arrange
            Customer myCustomer = new Customer();
            myCustomer.IsFemale = true;
            myCustomer.Age = 30;
            myCustomer.Active = true;
            myCustomer.ActivityLevel = ActivityLevel.HIGH;

            // Act
            myCustomer.CalculateOutputs();

            // Assert
            Assert.AreEqual(myCustomer.FormulaType, "Hunt");
            Assert.AreEqual(myCustomer.MHR, 191);
            Assert.AreEqual(myCustomer.TargetMax, 179);
            Assert.AreEqual(myCustomer.TargetMin, 160);
        }
    }
}