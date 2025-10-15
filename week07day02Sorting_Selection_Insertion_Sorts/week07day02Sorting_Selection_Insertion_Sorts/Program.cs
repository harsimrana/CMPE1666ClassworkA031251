
namespace week07day02Sorting_Selection_Insertion_Sorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array to stores numbers
            int[] numbers = { 56, 7, 4, 9, 21, 37, 17, 91 };

            // Print array before sorting
            Console.WriteLine("List before sorting");
            PrintValues(numbers);

            // Sort the list using 
            SelectionSort(numbers);

            // Print array after sorting
            Console.WriteLine("List after sorting");
            PrintValues(numbers);

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
                for (int j = i + 1; j < numberOfElements; ++j )
                { 
                    if (arr[j] < arr[minElementIndex] )
                    {
                        minElementIndex = j;
                    }
                }

                //Swap the found minimum element
                int temp = arr[minElementIndex];
                arr[minElementIndex] = arr[i];
                arr[i] = temp;
            }
            
        }
    }
}
