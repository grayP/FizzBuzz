using FizzBuz.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class TestStringReturnedIsCorrect
    {
        private FizzBuzzModel fizzBuzzCalculator = new FizzBuzzModel();

        [TestMethod]
        public void MultiplesOfThreeReturnFizz()
        {
            var inputValue = 3;
            var expectedReply = "Fizz";
            Assert.AreEqual(fizzBuzzCalculator.GetTheFizzBuzz(inputValue), expectedReply);
        }

        [TestMethod]
        public void MultiplesOfFiveReturnFizz()
        {
            var inputValue = 5;
            var expectedReply = "Buzz";
            Assert.AreEqual(fizzBuzzCalculator.GetTheFizzBuzz(inputValue), expectedReply);
        }

        [TestMethod]
        public void MultiplesOfThreeAndFiveReturnFizzBuzz()
        {
            var inputValue = 15;
            var expectedReply = "FizzBuzz";
            Assert.AreEqual(fizzBuzzCalculator.GetTheFizzBuzz(inputValue), expectedReply);
        }

        [TestMethod]
        public void NonMultiplesReturnInput()
        {
            var inputValue = 2;
            var expectedReply = "2";
            Assert.AreEqual(fizzBuzzCalculator.GetTheFizzBuzz(inputValue), expectedReply);
        }

        [TestMethod]
        public void NonMultiplesAndErrorReturnInput()
        {
            var inputValue = 3.1;
            var expectedReply = "3.1";
            Assert.AreEqual(fizzBuzzCalculator.GetTheFizzBuzz(inputValue), expectedReply);
        }
    }
}
