using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while(index <= 5) //() the information in here is called the Condition. First thing the loop does is check this condition
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine(" ");

            do //This will execute the code before checking the condition and run it through again

            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


            Console.ReadLine();
        }
    }
}
