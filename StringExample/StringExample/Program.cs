using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write your full name.");
            //Read information for terminal. I can use String for variables or var
            //var fullUserName = Console.ReadLine();
            string fullUserName = Console.ReadLine();

            //Print value of fullUserName variable
            Console.WriteLine("Hello " + fullUserName + ", Welcome to Platzi.");
        }
    }
}
