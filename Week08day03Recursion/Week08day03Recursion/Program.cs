using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08day03Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 08L Day 03 24.10.2025 Recursion");

            /*
             * Recursion: when a method calls itself
             * Any programming problems which can be solved using a loop can also be solved using recursion
             * Calling phase -> Base case -> Return Phase
             * Missing base case - Infinite loop
             * 
             */

            // Using loop print 1 to 5 numbers on screen
            for (int i = 1; i <= 5; ++i)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Same solution using recursion");
            PrintNumber(1);

            // Factorial 5!= 5 x 4 x 3 x 2 x 1 = 120 

            Console.WriteLine($"5!=  { Factorial(5) } " );
        }

        private static int Factorial(int n)
        {
            if (n == 0)  // Base Condition because 0! = 1
                return 1;
            else
                return n * Factorial(n - 1);  // n * (n-1)!
        }
        private static void PrintNumber(int n)
        {   // Always put base condition as the the first thing
            if (n > 5)              // Base case: Going to Stop Recursive calls
                return;
            // Crucial to decide where to put base case
            
            PrintNumber(n + 1);    // Calling The same function
            Console.WriteLine(n);  // Action

        }
    }
}
