using System;

namespace BuildAnExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //An exponent function is where we can pass in two numbers, a base number and a power number, and it'll raise
            //the base number to the power you decalre
            Console.WriteLine(GetPow(3, 4));
        }

        static int GetPow(int baseNum, int powNum) //Accepts two params, basenum and pownum
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }
}
