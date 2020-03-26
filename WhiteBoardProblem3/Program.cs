/*This problem was asked by Facebook
 * 
 * Given a array of numbers representing the stock prices of a company in chronological order, write a function that calculates the maximum
 * profit you could have made form buying and selling that stock once. You must buy before you can sell it.
 * 
 * For example, given [9, 11, 8, 5, 7, 10], you should return 5, since you oculd buy the stock at 5 follars and sell it at 10 dollars.
 * 
 */
using System;

namespace WhiteBoardProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int[] test = new int[] { 9, 11, 8, 5, 7, 10 };
            Console.WriteLine(findProfit(test));

        }

        public static int findProfit(int[] input)
        {

            int bestProfit = 0;
            for (int i = 0; i < input.Length; i++)

                for (int j = i + 1; j < input.Length; j++)
                {

                    if (input[i] < input[j])
                    {
                        int Profit = input[j] - input[i];
                        if (Profit > bestProfit)
                        {
                            bestProfit = Profit;
                        }
                    }


                }
            return bestProfit;

        }
    }
}
