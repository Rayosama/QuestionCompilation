using System;

namespace SumOfTheDigits
{
    class Program
    {
        //Write a method to sum up the digits of a number. Like 123 = 1+2+3 = 6
        static int getSum(int n)
        {   
            int sum = 0;

            while (n != 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }

            return sum;
        }
        public static void Main()
        {
            Console.WriteLine("What is your number?");
            Console.WriteLine(" ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write(getSum(n));
        }
    }
}
