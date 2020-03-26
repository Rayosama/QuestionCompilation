using System;

namespace MaxCharCount
{
    class Program
    {
        //Given a string input, return the Char that appears the most
        //string will be lowercase, and will not be empty




        static void Main(string[] args)
        {
            Console.Write("Enter your word to find the Char that exsist the most: ");
            string input = Console.ReadLine();
            Console.WriteLine($"The char that appears the most is:{0} ", mostChar(input));
        }

        static char mostChar(string word)
        {
            
            int length = word.Length;
            char test = ' ';
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < length; i++)
            {
                count = 0;
                for (int x = i + 1; x < length; x++)
                {
                    if (word[i] == word[x])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            test = word[i];

                        }
                    }
                }
            }
            return test;

        }
    }
}
