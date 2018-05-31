namespace FizzBuz.Service
{
    public static class CalculateIfMultiple
    {
        public static bool IsMultipleOfThree(double input)
        {
            return input / 3.0 == (int)input / 3;
        }
        public static bool IsMultipleOfFive(double input)
        {
            return input / 5.0 == (int)input / 5;
        }

        public static bool IsMultipleOfFiveAndThree(double input)
        {
            return IsMultipleOfFive(input) && IsMultipleOfThree(input);
        }

    }
}
