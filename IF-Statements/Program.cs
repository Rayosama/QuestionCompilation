using System;

namespace IF_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //If statements can only be true or false
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall) // || Is our OR statement
            {
                Console.WriteLine("You are a tall male ");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall) 
            {
                Console.WriteLine("You are tall but not a male");
            }
            else
            {
                Console.WriteLine("You are either not male or tall, or you don't fit in at all");
            }
        }
    }
}
