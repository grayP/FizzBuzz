using FizzBuz.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void NumberIsMultipleOfThree()
        {
            double value = 3;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfThree(value));
            value = 4;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfThree(value));
            value = 3.1;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfThree(value));
            value = 66;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfThree(value));
            value = 2;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfThree(value));

        }

        [TestMethod]
        public void NumberIsMultipleOfFive()
        {
            double value = 5;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfFive(value));
            value = 4;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfFive(value));
            value = 5.0;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfFive(value));
            value = 70;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfFive(value));
            value = 2;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfFive(value));

        }

        [TestMethod]
        public void NumberIsMultipleOfFiveAndThree()
        {
            double value = 15;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfFiveAndThree(value));
            value = 4;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfFiveAndThree(value));
            value = 15.0;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfFiveAndThree(value));
            value = 45;
            Assert.IsTrue(CalculateIfMultiple.IsMultipleOfFiveAndThree(value));
            value = 2;
            Assert.IsFalse(CalculateIfMultiple.IsMultipleOfFiveAndThree(value));

        }
    }
}
