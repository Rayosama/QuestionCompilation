using System;

namespace Review2
{
    class Program
    {
        static int SumTWoValues(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static void Main(string[] args)
        {
            //Below we're calling the method above us, assigning values, then adding it to it's self, so it ends up being 7+14=21
            int result = SumTWoValues(2, 5);
            result += SumTWoValues(result, result);
            Console.WriteLine(result);
            //Now if else statements
            if (boolean_predicate1)
            {
                //statements executed if boolean_predicate_1 is true
            }
            else if (boolean_predicate_2)
            {
                //statements executed if boolean_predicate1 is false AND boolean_predicate_2 is true
            }
            else
            {
                //statements executed if boolean_predicate 1 is false AND boolean_predicate_2 is false
            }
            //Now The different loops
            //First, while loop
            int x;
            x = 0;



            while (x < 5)
            {
                Console.WriteLine(x++);
            }
            //For Loop
            for (int y = 0; y < 4; y++)
            {
                Console.WriteLine(y);
            }
            //do/while loop
            int z = 0;
            do
            {
                Console.WriteLine();
            } while (++z < 5);
        }
    }
}
