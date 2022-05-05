﻿using System;

namespace PalindromeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalNumber, tempNumber, remainder, reverseNumber = 0;

            Console.WriteLine("\n");
            Console.WriteLine("Enter an integer number");
            originalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            tempNumber = originalNumber;

            Console.WriteLine("=============Logic Calculation==============");
            Console.WriteLine("===== Before While Loop =====");
            Console.WriteLine("Original number =" + originalNumber);
            Console.WriteLine("Temporary number =" + tempNumber);
            Console.WriteLine("Reverse number =" + reverseNumber);
            Console.WriteLine("\n\n");

            Console.WriteLine("===== While loop start==============");

            while (originalNumber > 0)
            {
                remainder = originalNumber % 10;
                Console.WriteLine("Remainder =" + remainder);
                reverseNumber = reverseNumber * 10 + remainder;
                Console.WriteLine("Reverse number =" + reverseNumber);
                originalNumber /= 10;
                Console.WriteLine("Original number =" + originalNumber);
                Console.WriteLine("Iteration complete\\n");
            }
            Console.WriteLine("===== While loop ending==============");
            Console.WriteLine("\n\n");

            Console.WriteLine("===== After loop ================");
            Console.WriteLine("===== Find Reverse Number =====");
            Console.WriteLine("Original number : {0}", tempNumber);
            Console.WriteLine("Reverse number  : {0}", reverseNumber);
            Console.WriteLine("===============================\n");

            Console.WriteLine("================================");
            if (tempNumber == reverseNumber)
            {
                Console.WriteLine("Entered Number is a palindrome Number");
            }
            else
            {
                Console.WriteLine("Entered Number is not a palindrome  Number");
            }
            Console.WriteLine("================================\n");
            Console.ReadLine();
        }
    }
}