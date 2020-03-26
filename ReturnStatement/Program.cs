using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5); //Assigning the value from cube with 5 as a parameter and storing it in cubedNumber
            
            Console.WriteLine(cubedNumber); //Printing out the value from cubedNumber
            
            
            
            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num; //cubing the users input
            return result; //This is how we send information back to Main
        }
    }
}
