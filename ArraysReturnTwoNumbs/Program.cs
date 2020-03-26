using System;

namespace ArraysReturnTwoNumbs
{
    class Program
    {
        /* Gi-ven an array of ints, arr, and an int k.
         * Return whether any wto numbers from the array add up to k
         * ie: Given=arr=[10,15,3,7], k=17---> Return: true
         * Given: arr=[2,8,45,50,94], k=100 ---->return: false
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public static bool AnyTwoNumbers(int k, int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int b = i + 1; b < arr.Length; b++)
                {
                    if (arr[i] + arr[b] == k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
