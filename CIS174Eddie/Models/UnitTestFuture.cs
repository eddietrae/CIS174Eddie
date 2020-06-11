using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS174Eddie;
using CIS174Eddie.Models;

namespace CIS174Eddie.Models
{
    // Unit Tests For FirstResponsiveWebAppEddie
    [TestClass]
    public class UnitTest
    {
        // Testing that valid input for AgeThisYear fuction returns expected value
        [TestMethod]
        public void AgeThisYear_IsValid()
        {
            // Arrange
            FutureAge age = new FutureAge();
            age.BirthYear = 2019;
            int? actual;
            int expected = 1;

            // Act
            actual = age.AgeThisYear();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        // Testing that input does not return unexpected value. Probably pointless in this case
        [TestMethod]
        public void AgeThisYear_IsInvalid()
        {
            // Arrange
            FutureAge age = new FutureAge();
            age.BirthYear = 2018;
            int? actual;
            int notExpected = 1;

            // Act
            actual = age.AgeThisYear();

            // Assert
            Assert.AreNotEqual(notExpected, actual);

        }
    }
}
