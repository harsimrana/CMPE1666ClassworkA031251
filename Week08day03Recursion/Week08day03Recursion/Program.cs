using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08day03Recursion
{
    internal class Program
    {
        public static int count = 0;
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
            Console.WriteLine($"Sum of numbers till {5} =  {CalculateTotal(5)} ");

            // 1+ 2+ 3 + ...... + n = n * ( n + 1) / 2

            // Declare an array for Linear search operation
            int[] numbers = { 4, 5, 9, 15, 21, 37, 57, 91, 99};
            int itemSeach = 7;
/*
            int indexOfItem = LinearSeachIterative(numbers, itemSeach);

            if(indexOfItem ==-1)
                Console.WriteLine($"{itemSeach}  is Not Found in the list");
            else
                Console.WriteLine($"{itemSeach}  is Found at index {indexOfItem}");
*/
/*
            int indexOfItem = LinearSeachRecursive(numbers, itemSeach, 0);

            if (indexOfItem == -1)
                Console.WriteLine($"{itemSeach}  is Not Found in the list");
            else
                Console.WriteLine($"{itemSeach}  is Found at index {indexOfItem}");
*/
         // UNCOMMENT THE FOLLOWING BLOCK TO TEST IT USING ITERATIVE VERSION
/*
            int indexOfItem = BinarySeachIterative(numbers, itemSeach);

            if (indexOfItem == -1)
                Console.WriteLine($"{itemSeach}  is Not Found in the list");
            else
                Console.WriteLine($"{itemSeach}  is Found at index {indexOfItem}");
*/
            // Test binary search using recursive version
            // UNCOMMENT THE FOLLOWING BLOCK TO TEST IT RECURSIVELY

            int indexOfItem = BinarySeachRecursive(numbers, itemSeach, 0, numbers.Length-1);

            if (indexOfItem == -1)
                Console.WriteLine($"{itemSeach}  is Not Found in the list");
            else
                Console.WriteLine($"{itemSeach}  is Found at index {indexOfItem}");
            Console.WriteLine($" It took {count} comparisons");
        }

        public static int BinarySeachRecursive(int[] collection, int target, int low, int upper)
        {
            if (low <= upper)
            {
                int mid = (low + upper) / 2;
                count++;

                if (collection[mid] == target)
                    return mid;  // Found the match so return the index of that element
                else if (target < collection[mid])
                {
                    // Need to search in the left half of the list
                    return BinarySeachRecursive(collection, target, low, mid - 1);
                }
                else if (target > collection[mid])
                {
                    // Need to search in the right half of the list
                    return BinarySeachRecursive(collection, target, mid + 1, upper);
                }
            }
            return -1; // not in the list
        }
        private static int BinarySeachIterative(int[] collection, int target)
        {
            int low = 0, upper = collection.Length - 1, mid;
           
            while ( low <= upper)
            {
                mid = (low + upper) / 2;  // Observe int division here

                if (collection[mid] == target)
                    return mid;
                else if (target < collection[mid])
                { // item is in left half of the list 
                    upper = mid - 1;
                }
                else
                { // item is in the right half of the list
                    low = mid + 1;
                } 
            }
            return -1; // not in the list
        }

        private static int LinearSeachRecursive(int[] collection, int target, int index  = 0)
        {
            // Base Case 2: Element not foound (index out of bound)
            // It is important to put case first: Index is going to be outside the upper bound for the final call
            if (index >= collection.Length)
                return -1;

            // Base case 1: Element found
            if (collection[index] == target)
                return index;

            return LinearSeachRecursive(collection, target, index + 1);
           
        }
        private static int LinearSeachIterative(int[] collection, int target)
        {
            //int indexSearchItem = -1;  // -1 means not found

            for (int i = 0; i < collection.Length; ++i)
            {
                if (collection[i] == target)
                {
                    return i;  // returning the index of item
                }
            }
            // If you are here it means item is not found in the list
            return -1; // -1 means not in list 
        }

        // Write a method to calculate total of first n numbers- Where N is provided by user

        private static int CalculateTotal(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + CalculateTotal(n - 1);
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
