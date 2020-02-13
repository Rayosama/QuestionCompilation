using System;

namespace FizzBuzz
{
    class Program
    {
        /*Write a method which takes a value, n, as input and prints out the values [1-n] but prints out:
         "fizz" for values divisble by 3, "buzz" for values divisible by 5, "fizzbuzz" for values divisble by both 3 & 5 
         */
        static void Main(string[] args)
        {
            FizzBuzz(20);
        }

        static void FizzBuzz(int n)
        {
            
            for(int i =1; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }   
            }
        }
    }
}
