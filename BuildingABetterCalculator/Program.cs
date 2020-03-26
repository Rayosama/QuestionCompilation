using System;

namespace BuildingABetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your operator: ");
            string op = Console.ReadLine();

            
            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write("The total is: ");
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }


            Console.ReadLine();
        }
    }
}
