﻿using System;

namespace StringIsAPalindrome
{
    public class IsPalindrome
    {
        public class Palindrome
        {
            public static void Main(string[] args)
            {
                string inputStr, r;
                inputStr = "Madam";
                char[] letter = inputStr.ToCharArray();
                Array.Reverse(letter);
                r = new string(letter);
                bool bool1 = inputStr.Equals(r, StringComparison.OrdinalIgnoreCase);
                if (bool1 == true)
                {
                    Console.WriteLine("This string " + inputStr + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine("This string " + inputStr + " is not a Palindrome!");
                }
                Console.ReadLine();
            }
        }
    }
}
