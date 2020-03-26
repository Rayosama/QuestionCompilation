using System;

namespace Exercise_5__Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ARRAY A: 0,2,4,6,8,10
             * ARRAY B: 1,3,5,7,9
             * ARRAY C: 3,1,4,1,5,9,2,6,5,3,5,9
             */

            /*Question 1: Write a method counts the number of elements in an integer array, and then sums the elements in an integer array. 
             * It should return the average of the array elements as a double. Using the count and sum, compute and print the mean of each array.
             */

            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int ACount = A.Length;
            //Console.Write(ACount);
            int sumA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }
            double aMean = (sumA / ACount);

            Console.WriteLine("The mean for Array A is: " + aMean);
            Console.WriteLine(" ");

            int BCount = B.Length;
            //Console.Write(ACount);
            int sumB = 0;
            for (int i = 0; i < B.Length; i++)
            {
                sumB += B[i];
            }
            double bMean = (sumB / ACount);

            Console.WriteLine("The mean for Array B is: " + BCount);
            Console.WriteLine(" ");

            int CCount = C.Length;
            //Console.Write(ACount);
            int sumC = 0;
            for (int i = 0; i < C.Length; i++)
            {
                sumC += C[i];
            }
            double cMean = (sumB / ACount);

            Console.WriteLine("The mean for Array C is: " + CCount);
            Console.WriteLine(" ");

            /*Question 2: Reversing Arrays: Write a method that accepts an array as an arguement and prints the reversed array. 
            For example, if you pass the method Array B, it should print [9, 7, 5, 3, 1]. Print the reverse of all three arrays.
            */

            /*Array.Reverse(A);
            Console.WriteLine("Array A backwards is: ");
            Console.WriteLine(" ");

            foreach (int value in A)
            {
                Console.WriteLine(value);
            }*/

            int j = 0;
            Console.WriteLine(" ");
            Console.WriteLine("Let us see what Array A looks like backwards: ");
            Console.WriteLine(" ");

            for (j = A.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(A[j]);
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Let us see what Array B looks like backwards: ");
            Console.WriteLine(" ");

            int k = 0;

            for (k = B.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(B[k]);
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Let us see what Array C looks like backwards: ");
            Console.WriteLine(" ");
            int l = 0;
            for (l = C.Length - 1; l >= 0; l--)
            {
                Console.WriteLine(C[l]);
                Console.WriteLine(" ");
            }

            /* Question 3; Rotating Arrays: Arrays can be rotated to the right or to the left by any number of places. Rotating an array to the
             * right by two places puts the first element in position three, the second element in position four, and so on, with the last element
             * in position two and the next to last element in position one. Array A rotated to the right by two places results in [8, 10, 0, 2, 4, 6].
             * Write a method that accepts three parameters, a direction (right or left), a number of places, and an array, which prints the
             * appropriate rotation. Call the method on all three arrays. Rotate array A two places to the left. Rotate aray B two places to the right.
             * Rotate array C four places to the left.
             */

            // Array B
            //The  of length is 1 2 3 4 5 
            // index value: 0 1 2 3 4

            Console.WriteLine(" ");

            Console.WriteLine("Invalid entry; please try again");



        }
    }
}
