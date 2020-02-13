using System;

namespace AmazonQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can climb up a staircase 1 or 2 steps at a time. Given that the staircase has N steps total, calculate the unique number of ways to climb the staircase.
            Console.WriteLine($"Number of outcomes {countNumWays(4)}"); //Need to call the countNumWays in the main method
        }
        static int countNumWays(int n)
        {
            if (n <= 1) //base case
                return 1;
            return countNumWays(n - 1) + countNumWays(n - 2); //The recurrsion part that goes through all the outcomes


        }
       
    }
}
