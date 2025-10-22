using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Week 08 Day 02: 22.10.2025
// Adding Insertion sort part to extend it further
namespace Week07d2Selection_Insertion_SortAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array to stores numbers
            int[] numbers = { 1000, 7, 0, 9, 21, -37, 17, -1 };

            // Print array before sorting
            Console.WriteLine("List before sorting");
            PrintValues(numbers);  //n

            // Sort the list using 
            //SelectionSort(numbers);

            // Sort using insertsort
            InsertionSort(numbers); //n2

            // Print array after sorting
            Console.WriteLine("List after sorting");
            PrintValues(numbers);  //n

            // n2+ 2n  
            Console.ReadKey();

        }

        // Print the array to console window
        public static void PrintValues(int[] list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
        // Week 07 
        //Method to perform selection sort
        // Inputs:  An array to sort
        // Return:  Nothing
        public static void SelectionSort(int[] arr)
        {
            int numberOfElements = arr.Length;

            for (int i = 0; i < numberOfElements - 1; ++i)
            { // Number of passes 

                int minElementIndex = i;

                // Finding the smallest element's index from rest of the list
                for (int j = i + 1; j < numberOfElements; ++j)
                {
                    if (arr[j] < arr[minElementIndex])
                    {
                        minElementIndex = j;
                    }
                }

                //Swap the found minimum element
                int temp = arr[minElementIndex];
                arr[minElementIndex] = arr[i];
                arr[i] = temp;

                // Without using temp location
                // UNCOMMENT THE FOLLOWING TO TEST IT WITH FOLLOWING LOGIC WITHOUT TEMP LOCATION
                /*
                arr[minElementIndex] = arr[minElementIndex] + arr[i];
                arr[i] = arr[minElementIndex] - arr[i];
                arr[minElementIndex] = arr[minElementIndex] - arr[i];
                */
            }

        }// end of function seletion sort

        // Week 08 Day 02: 22.10.2025
        // Method to perform insertion sort
        // Inputs:  An array to sort
        // Return:  Nothing
        public static void InsertionSort(int[] arr)
        {
            //int[] numbers = { 56, 7, 4, 9, 21, 37, 17, 91 };

            for (int i = 1; i < arr.Length ; ++i)
            {
                //Key: Element to be inserted
                int temp = arr[i];
                int j = i - 1;

                // Move elements greater than key to one position ahead 
                while (j >= 0 && temp < arr[j]  ) 
                {   
                    arr[j+1] = arr[j];
                    j--;
                }
                // Insert the key at the correct position
                arr[j +1] = temp;
            }
        }// end of function Insertion
    }//End of Class
}// End of namespace
