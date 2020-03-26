using System;

namespace More_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMax(20, 10, 340));
        }

        static int getMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3) 
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else //Since we already made sure num1 and num2 weren't the highest, only option left is num3
            {
                result = num3;
            }
            return result;

        }
    }
}
