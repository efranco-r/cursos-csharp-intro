using System;

namespace NumericCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numberOne;
            int numberTwo;

            Console.WriteLine("Please, input the first number:");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, input the second number:");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            int result = numberOne * numberTwo;

            Console.WriteLine(numberOne + " * " + numberTwo + " = " + result);
        }
    }
}
