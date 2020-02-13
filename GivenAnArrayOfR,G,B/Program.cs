using System;

namespace GivenAnArrayOfR_G_B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given an array of 'R', 'G', 'B' values, sort it such that all of the 'r' first, all of the 'g' second, and all of the 'B' last
               An example would be Given { 'R','B','G','R','G','B'} Return {'R','R','G','G','B','B'}*/


            string letters = "RBGRGBRGBBRGRGBRGB"; //This is our starting value. We created a string, and named it letters
            char[] letters2 = letters.ToCharArray(); //Here we declare a char and name it letters2. We then associate letters to this and then send it to a Character Array
            Array.Sort(letters2); //This first sorts the all the characters in order
            Array.Reverse(letters2); //We now reverse that order
            string Final = String.Empty; //Now we create a new string named Final and set it equal to an empty string
            foreach (char character in letters2) //Here we're saying for each character (which we named character) in letters 
                Final += character.ToString(); //We then plug them into our empty string Final, and convert character to a string
            Console.WriteLine(Final); //Here we write to screen our string Final


            //To do it without using the built-in functions
        }

       
    }
}
