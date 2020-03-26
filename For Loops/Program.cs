using System;

namespace For_Loops
{
    class Program
    {
         

        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(" ");

            for(int j = 0; j <= 5; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine(" ");

            //Using a For loop to go through an array and print each character
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int k = 0; k < luckyNumbers.Length; k++)
            {
                Console.WriteLine(luckyNumbers[k]);
            }

        }
    }
}
