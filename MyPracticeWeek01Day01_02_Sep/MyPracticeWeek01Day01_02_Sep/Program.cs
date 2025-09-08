using System.Data.SqlTypes;

namespace MyPracticeWeek01Day01_02_Sep
{
    internal class Program
    {
        // No Global variables
        struct Employee
        {
            public int Id;
            public string Name;
            public double Salary;

            public Employee(int id, string name, double salary)
            {
                Id = id;
                Name = name;
                Salary = salary;

            }

            public void DisplayInfo()
            {
                Console.WriteLine($" ID : {Id}  Name = {Name} Salary = {Salary}");
            }

        }

        static void Main(string[] args)
        {
            // Single line comments
            /* Multi line comments
             * 
             */

            // Declaring required variable 
            /*
            double radius, areaCircle;
            string name;
            char choice;

            do
            {
                //Inputs
                Console.Write("Enter the value of radius of circle: ");
                radius = double.Parse(Console.ReadLine());

                if (radius > 0 && radius < 100) // Compound condition: using logical operator Logical AND
                {

                    // Processing
                    areaCircle = Math.PI * radius * radius;

                    // Output
                    // Showing the output back to used till 2 decimal places
                    Console.WriteLine($"Area of the circle = {areaCircle:0.00}");
                }
                else
                {
                    Console.WriteLine("Radius must be greater than 0 and less than 100");
                }

                Console.Write("Press Y to continue: ");
                choice = char.Parse(Console.ReadLine());


            } while (choice == 'Y' || choice =='y');


            */

            // Loops

            //int number;

            //Console.Write("For which  number you need multiplication table :");
            //number = int.Parse(Console.ReadLine());

            //PrintTable(number);

            /*
             Create an array and populate the array by taking values from user
             Then, Print all the values on console window
             */

            /*
            // Declaring and initializing an array
            int[] marks = { 2, 3, 4, 5 };
            int i = 0;
            int sum = 0;
            double meanAverage;

            // Input from user
            while(i < marks.Length)
            {
                Console.Write($"Enter element number {i + 1} :");
                marks[i] = int.Parse(Console.ReadLine());
                sum = sum + marks[i];

                i++;
                
            }

            meanAverage = (double)sum / marks.Length;

            //Print the array
            foreach (int element in marks)
            {
                Console.WriteLine(element);
            
            }

            Console.WriteLine($" Sum of these numbers = {sum}");
            Console.WriteLine($" Mean Average of these numbers = {meanAverage}");
            */
            Random rn = new Random();

            Console.WriteLine($" Random Number {rn.Next(1, 7)}");

            Employee emp1 = new Employee(1, "Harsimran", 15.6);

            Console.Write($" Employee info  {emp1.Name}  {emp1.Salary} {emp1.Id}");

            // Create an array of Employee struct with 3 employees

            // DataType [] nameOfArray = new nameOfArray[n]

            Employee[] companyEmployees = new Employee[10];

            companyEmployees[0] = new Employee(1, "Harsimran", 15.6);

            // What is the difference between value type and reference

            // Create a simple ball on the screen



        }
        public static void PrintTable(int number)
        {
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine($" {number} x {i} = {number * i}");
            }
        }
    }
}
