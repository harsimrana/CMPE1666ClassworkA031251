using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Day03StringComparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {// Week 09 Day 03 31.10.2025
            string usernameDB = "Simran123";
            string usernameclient = "Simran123";
            // exact comparison is possible directly using == operators
            if (usernameDB == usernameclient)
            {
                Console.WriteLine($"Welcome {usernameclient}");
            }
            else
            {
                Console.WriteLine("Wrong Username Try again!");
            }
            // I need to sort list of strings

            int result = string.Compare("ABC", "ABC ");
            //result= usernameDB.CompareTo(usernameclient);
            // 0  - if both the string are equal
            // -1 - if the first string is lexicoggraphically smaller than the second  string
            // +1 - if the first string is lexicoggraphically greater than the second  string

            Console.WriteLine($" Value returned by compare method {result}");
            if (result == 0)
            {
                Console.WriteLine("Strings are equal");
            }

            // Different types of Recursion
            // where you are doing the processing
            // 1. Pre-Order  : Processing before making recursive call
            // 2. Post-Order : Processing after making recursive call
            // 3. InOrder    : Processing before and after making recursive call

            // Write a recursive method to find whether a string in Palindrome or not
            //Palindrome : a sequence of characters that reads the same forward and bacward
            // like madam
        }
    }
}
