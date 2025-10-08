// Week 05 day 02: 08 Oct, 2025 File processing
// 1. Writing data to a file
// 2. Readiang data from a file 

using System.IO;

namespace week06day02_08oct_fileprocessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File processing");
            // File class can be used to work with your files
            // using system.IO
            // To write into a file : use following method
            /*
             * File.WriteAllLines (file_path, datatofile) -- data will be in string format
             * 
             * To Read data from file: use following method
             * 
             * File.ReadAllLines(file_path)
             * -- Read all liners from a file and return as an array of strings
             * 
             * File.ReadAllText(file_path)
             * -- Read all data from the file and returns it as ONE string
             */
            // Storing file path in a variable
            string filePath = "../../../../students.txt";

            // Example data to write
            string[] students = { "Simran", "Lovelyn", "Elodie", "Meeca", "Jessah", "Habib", "Simon" };

            // Write all lines to the text file
            // UNCOMMENT THE FOLLOWING LINE TO WRITE DATA TO FILE
            //File.WriteAllLines(filePath, students);

            //Console.WriteLine("Data written to file successfully ");

            try
            {
                // Read all lines from the file
                string[] readData = File.ReadAllLines(filePath);
                Console.WriteLine("Data from file:");
                int numberOfLines = 0;
                //Reading one element from readData array and printing it
                foreach(string line in readData)
                {
                    numberOfLines++;
                    Console.WriteLine(line);
                    
                    string[] subStrings = line.Split(',');
                    if (subStrings.Length > 1)
                    {
                        Console.WriteLine("Word in the line are following: ");
                        foreach (string word in subStrings)
                        {
                            Console.Write(word + " ");
                        }
                        Console.WriteLine("");
                    }
                    
                }
                Console.WriteLine($"Number of Lines in the file {numberOfLines}");

                // Reading all text at once
                string fileData = File.ReadAllText(filePath);

                Console.WriteLine(fileData);

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
    }
}
