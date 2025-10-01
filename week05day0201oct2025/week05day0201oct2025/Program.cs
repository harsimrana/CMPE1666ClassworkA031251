namespace week05day0201oct2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              List: is similar to array 
              - store multiple entities of given type
              - access an element using the name of the list and index  
              - List variable is reference type  
             */

            // Create a list

            // List <data type> nameOfList = new List <Data type> ();
            List<int> number = new List<int>(); // Empty list to maintain interger values
            List<int> marks = new List<int>() {10,12,15}; // List with 3 starting values
                                                   // Maximum of elements
            List<string> studentNames = new List<string>(20) {"ABC", "XZY", "Simran", "123" }; // List with 3 starting values 

            // Access the list elements
            // Trying to access first element from both lists which is at index position 0
            Console.WriteLine($" Student {studentNames[0]}  : {marks[0]}");


            Console.WriteLine("List of all the students ");
            // Iterate the list 
            // Count property will give you current total number of elements in the list
            for (int i = 0; i < studentNames.Count; ++i)
            {
                Console.WriteLine(studentNames[i]);
            }


            // Basic Operations possible on list
            /*
                Add elements
                Insert elements
                Remove elements
             */

            // Add an element to studentNames list
            studentNames.Add("Adam");  // At the new element at the end of the list

            Console.WriteLine("After adding new element revised list:");
            for (int i = 0; i < studentNames.Count; ++i)
            {
                Console.WriteLine(studentNames[i]);
            }

            // Insert an element in a list : specifix index
                           // index    value
            studentNames.Insert(2,    "NULL");

            // Create an array and add it to your list
            string[] newNames = ["123", "456", "789"];

            // Insert new set of names at index position 2 in our list
            studentNames.InsertRange(2, newNames);

            Console.WriteLine("After inserting new element revised list:");
            // Calling user defined method to print list
            PrintList(studentNames);

            //Break Time till 2:00 PM

            //Remove an element from the list 
            // element to be deleted : the first occurrence
            studentNames.Remove("123");

            Console.WriteLine("After reming 123 element revised list:");
            // Calling user defined method to print list
            PrintList(studentNames);


            //   index position
            studentNames.RemoveAt(0);

            Console.WriteLine("After reming first elemtent Index 0 element revised list:");
            // Calling user defined method to print list
            PrintList(studentNames);


            // Count property: will give total number of elements
            Console.WriteLine($"Total elements in the list {studentNames.Count}");
            // number of elements list can contain. The default capacity : 0 
            Console.WriteLine($"Total capacity in the list {studentNames.Capacity}");
            

            // Clear your list
            //studentNames.Clear(); // delete all the elements from the list

            Console.WriteLine("After clearing list revised list:");
            // Calling user defined method to print list
            PrintList(studentNames);

            // sort your list 
            studentNames.Sort();  // sort your list using Quicksort algoright for sorting

            Console.WriteLine("After sorting list revised list:");
            // Calling user defined method to print list
            PrintList(studentNames);

            studentNames.Reverse();
            Console.WriteLine("After reveersing list revised list:");
            // Calling user defined method to print list
            PrintList(studentNames);

            //Max(), Min(), Average() 


            // string.join on a list will concat all the element
            //                              separator , list 
            // it will return a string value
            string concatedList = string.Join(",", studentNames);

            Console.WriteLine(concatedList);

            // Contain() - will find an element in the list Binary Search 

        }
        /* public static void PrintList(List<string> list)
           Purpose  : Print all the elements from the list
           Inputs   : List of string
           Returns  : Noting
        */
        public static void PrintList(List<string> list)
        {
            /*
            for (int i = 0; i < list.Count; ++i)
            {
                Console.WriteLine(studentNames[i]);
            }
            */

            // Iterating through my list one at a time and printing it
            foreach (string element in list)  
            {
                Console.WriteLine(element);
            }
        }


        /* Exercise Question: Try to complete it before the beginning of next class
          Create a list of struct :
           Student information 
                StudentName     [string]
                StudentMarks    [double]
                StudentEmail    [string]
                StudentAge      [int]
                
          Window app to give interface so user can:
                Add a new student               :   Button
                Remove a student                :   Button
                Insert a student specific index :   Button
                Clear all student from list     :   Button

         */
    }
}
