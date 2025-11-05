using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week10Day02QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 21, 12, 18, 30, 8, 23, 65, 41, 32 };

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            
            QuickSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("After sorting");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        // The QuickSort function implementation 
        private static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                //  Partition index 
                int partitionIndex = Partition(arr, low, high);

                // Recursive call for smalleer elements
                QuickSort(arr, low, partitionIndex - 1);
                // Recursive call for greater or equls elements
                QuickSort(arr, partitionIndex + 1, high);
            }
        }
        // Partition function will return the partitionIndex : final index position of 
        // pivot element in the list passed.
        private static int Partition(int[] arr, int low, int high)
        {
            // choose the pivot
            int pivot = arr[high];  // last element

            // Set all the pointers 
            int i = low - 1;

            // iterate the list adn move all elements small elements to the left side 
            // elements from low to i are smaller after every iteration
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // swap element i with j
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }

            // move pivot after smaller elements and return its position
            int temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;
            return i + 1; // index position of pivot element
        }
    }
}
