namespace Week06day1ShufflingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5] { 1, 2, 3, 4, 5 };

            // Calling DisplayData() to print the list before shuffling
            DisplayData(marks);

            //calling ShuffleData method to shuffle your list 
            ShuffleData(marks);

            //printing list again
            Console.WriteLine("After shuffling new list :");
            // Calling DisplayData() to print the list after shuffling
            DisplayData(marks);


        }

        // DisplayData() will print the array
        // Inputs       : collection
        // Return       : nothing
        public static void DisplayData(int[] myList)
        {
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }
        // ShuffleData: Will use Fisher yates algo to shuffle the values
        // Input      : collection
        // Return     : nothing
        public static void ShuffleData(int[] myList)
        {
            // Create a random object to generate random number
            Random rand = new Random();

            // Get the number of elements in list
            int numberOfElements = myList.Length;

            // Start shuffling using Fisher-Yates Algorithm
            // We iterate from the last element down to second element [index 1]
            for (int i = numberOfElements - 1; i > 0; --i)
            {
                // Generate a random index j between 0 - i (inclusive)
                // This ensures that each element can be swapped with any element before it, including itself
                int j = rand.Next(0, i + 1);

                // Swap the elements at position i and j
                // temp stores the element at i temporarily
                int temp = myList[i];

                // Place the element from position j into position i
                myList[i] = myList[j];

                // Put the element stored in temp [orgininally at i] into position j
                myList[j] = temp;

                // At this point, the element at index i has been randomly swapped
                // continue moving backwards until the collection is fully shuffled

            }
        }
    }
}
