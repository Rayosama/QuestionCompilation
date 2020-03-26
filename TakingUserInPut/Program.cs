using System;

namespace TakingUserInPut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking users input
            Console.WriteLine("Taking users input");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine(" ");
        }
    }
}
