using System;

namespace BuildingASimpleCalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building a calculator
            Console.WriteLine("Calculator example: ");
            int num = Convert.ToInt32("45"); //Converting a string to an integer
            Console.WriteLine(num + 5);

            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your total is: " + (num1 + num2));
            Console.WriteLine(" ");
        }
    }
}
