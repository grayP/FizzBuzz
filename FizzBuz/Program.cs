using FizzBuz.Model;
using System;


namespace FizzBuz
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFizzBuzz();
            Console.ReadLine();
        }

        private static void WriteFizzBuzz()
        {
            FizzBuzzModel fizzBuzzCalculator = new FizzBuzzModel();
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(fizzBuzzCalculator.GetTheFizzBuzz(i));
            }
        }
    }
}
