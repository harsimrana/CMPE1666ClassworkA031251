using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Day02DemoDelegates
{
    internal class Program
    {
        // To use delegate , delegate type 
        delegate void delSingleString(string str);
        static void Main(string[] args)
        {
            int ageUser = 25;  // ageUser an instance of an interger value.

            ageUser = 45;

            List<int> balls = new List<int>();

            // Similary a delegate creates an object that can be a reference to a method
            Console.WriteLine("Inside Main ");

            // Creating delegate object and assinging the method PrintName to it
            delSingleString delStr1 = new delSingleString(PrintName);

            // To execute the method, you can use invoke method 
            delStr1.Invoke(" Hello User My name is Simran");
            
            // You can omit the new and constructor stuff, C# will handle that for you
            delStr1 = PrintMarks;
            delStr1.Invoke("34");
        }

        public static void PrintName(string str)
        {
            Console.WriteLine($" Your Name {str}");
        }

        public static void PrintMarks(string str)
        {
            Console.WriteLine($"Your Marks {str}");
        }
    }
}
