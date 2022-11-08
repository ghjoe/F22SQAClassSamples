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
            Assert.AreEqual("Hunt", myCustomer.FormulaType);
            Assert.AreEqual(191, myCustomer.MHR);
            Assert.AreEqual(179, myCustomer.TargetMax);
            Assert.AreEqual(160, myCustomer.TargetMin);
        }

        // Tanaka formula (men and women over age 40): 208 - (0.7 × age)
        // 

        // PAIRWISE TOOL TESTS
        //Gender Active  Age Activity Levels
        //Female  True Over40  Regular
        //Male    False Over40  Minimal
        //Female  True	40OrUnder Minimal
        //Male False	40OrUnder High
        //Male False	40OrUnder Regular
        //Male True	40OrUnder Sporadic
        //Female False   Over40 Sporadic
        //Female True    Over40 High
        //Female True	40OrUnder Sedentary
        //Male False   Over40 Sedentary


        //Gender Active  Age Activity Levels
        //Female  True Over40  Regular
        // The HUNT formula (men and women who are active): 211 - (0.64 x age)
        // If you exercise regularly, you should work at 80% to 91% of your MHR.
        [TestMethod]
        public void FemaleOver40ActiveRegular()
        {
            // Arrange
            Customer myCustomer = new Customer();
            myCustomer.IsFemale = true;
            myCustomer.Age = 50;
            myCustomer.Active = true;
            myCustomer.ActivityLevel = ActivityLevel.REGULAR;

            // Act
            myCustomer.CalculateOutputs();

            // Assert
            Assert.AreEqual("Hunt", myCustomer.FormulaType);
            Assert.AreEqual(179, myCustomer.MHR);
            Assert.AreEqual(162, myCustomer.TargetMax);
            Assert.AreEqual(143, myCustomer.TargetMin);
        }

        //Gender Active  Age Activity Levels
        //Male    False Over40  Minimal
        // FormulaType = "Tanaka"; MHR = (int) (208 - .7 * Age);
        // If you engage in minimal activity, you should work at 64% to 74% of your MHR.        // 
        [TestMethod]
        public void MaleOver40NotActiveMinimal()
        {
            // Arrange
            Customer myCustomer = new Customer();
            myCustomer.IsFemale = false;
            myCustomer.Age = 70;
            myCustomer.Active = false;
            myCustomer.ActivityLevel = ActivityLevel.MINIMAL;

            // Act
            myCustomer.CalculateOutputs();

            // Assert
            Assert.AreEqual("Tanaka", myCustomer.FormulaType);
            Assert.AreEqual(159, myCustomer.MHR);
            Assert.AreEqual(117, myCustomer.TargetMax);
            Assert.AreEqual(101, myCustomer.TargetMin);
        }


    }
}