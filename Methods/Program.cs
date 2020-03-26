using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args) //Only method that gets run my CSharp
        {
            SayHi("Mike", 34); //Calling our method we made below to execute that block of code
            SayHi("John", 23); //Can call the method as much as you want
            SayHi("Tom", 42); //And also change its value
            Console.ReadLine();
        }

        //Creating new methods a.k.a a block of code that gets executed
        static void SayHi(string name, int age) //Will not execute unless called upon in main method   () is our parameter or arguement area
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        
    }
}
