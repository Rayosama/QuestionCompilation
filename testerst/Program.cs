using System;

namespace testerst
{
    class Program
    {
        // Write a method that takes 2 strings as input and returns true if the first string starts with the second string and returns false otherwise
        static void Main(string[] args)
        {
            Console.WriteLine(LibraryTest("Microsoft", "Micro"));
        }

        static bool LibraryTest(string word1, string word2)
        {
            
            
            for (int i = 0; i < word2.Length; i++)
            {
               
                if (word2[i] != word1[i])
                {

                    return false;

                }
                
            }
                return true;
        }
    }
}
