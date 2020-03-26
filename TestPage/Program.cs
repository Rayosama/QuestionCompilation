
using System;


namespace ReturnErrors
{
    public class Program
    {


        static void Main(string[] args)
        {

            
        }
        static bool Library(string word1, string word2)
        {
            for (int i = 0; i < word2.length; i++)
                if (word2[i] == word1[i]
                {
                    continue;
                }

        }

        static void firstNonDup(string given)
        {
            char result;
            //string empty = "Not a valid entry";
            //if (given == " ")
            // {
            // return empty;
            //  }
            for (int i = 0; i < given.Length; i++)
            {
                for (int j = i + 1; j < given.Length; j++)
                {
                    if (given[i] == given[j])
                    {
                        continue;
                    }
                    else if (given[i] != given[j])
                    {
                        result = given[j];
                        if (result == given[j + 1])
                        {
                            continue;
                        }
                        else if (result != given[j + 1])
                        {
                            Console.WriteLine(result);
                            
                        }


                        
                    }

                    
                }
                
            }
            

        }
    }
}





