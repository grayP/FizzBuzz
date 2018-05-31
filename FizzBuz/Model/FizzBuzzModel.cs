using FizzBuz.Constants;
using FizzBuz.Service;

namespace FizzBuz.Model
{
    public class FizzBuzzModel : IFizzBuzzModel
    {
        private string Fizzbuzz = OutputMessages.FizzBuzz;
        private string Fizz = OutputMessages.Fizz;
        private string Buzz = OutputMessages.Buzz;

        public FizzBuzzModel()
        {
        }
      
        public string GetTheFizzBuzz(double i)
        {
            return CalculateIfMultiple.IsMultipleOfFiveAndThree(i) ? Fizzbuzz : CalculateIfMultiple.IsMultipleOfFive(i) ? Buzz : CalculateIfMultiple.IsMultipleOfThree(i) ? Fizz : i.ToString();
        }
    }
}
