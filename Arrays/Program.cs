using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            // 0, 1, 2,   3,  4,  5 etc...
            luckyNumbers[1] = 900; //This will update the value at index 1 from 8 to 900, and will print new value beloew it
            Console.WriteLine(luckyNumbers[0]); //will grab item at index you specify in the []
            

            //Array of Strings

            string[] friends = new string[5];
            friends[1] = "Jim";
            friends[2] = "Kelly";
            Console.WriteLine((friends[1]), (friends[2]));
            Console.ReadLine();
        }
    }
}
