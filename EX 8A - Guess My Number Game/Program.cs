/*Bisection Algorithm This exercise implements three programs implementing the bisection algorithm.
The bisection method is an efficient way of finding a particular value in a sorted list. It takes a sorted list
and a value, and finds the value in the list. First, it checks the “middle” element in the list. There are
three possibilities: the value could match the “middle” element, the value could be higher than the ‘middle”
element of the list, or the value could be lower than the “middle” element. If the value matches, the function
returns. If it’s higher, the algorithm (recursively) calls itself with the top half of the list. If it’s lower, the
algorithm calls itself with the bottom half of the list.
For example, here is the output of a function call, the searched value being 7 and the sorted list being
[1 2 3 4 5 6 7 8 9 10].
*/


using System;

namespace EX_8A___Guess_My_Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}