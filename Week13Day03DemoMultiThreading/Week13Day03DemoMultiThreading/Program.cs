using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Week13Day03DemoMultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 13 Day 03 Demo ");
            Console.WriteLine("Multithreading ");
            // Thread objects
            Thread t1 = null, t2 = null, t3 = null;

            // Assigning different methods to different threads
            t1 = new Thread(FindSine);
            t2 = new Thread(FindCos);
            t3 = new Thread(displayMessage);

            // Starting all my threads
            t1.Start();
            t2.Start();
            t3.Start();


            //FindSine();
            //FindCos();
            //displayMessage();

        }

        public static void FindSine()
        {
            for (double x = 0; x < 180; x += 1)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");
                Thread.Sleep(100);
            }
        
        }

        public static void FindCos()
        {
            for (double x = 0; x < 180; x += 1)
            {
                double rad = Math.PI * x / 180;
                double cosValue = Math.Cos(rad);
                Console.WriteLine($" {x} degrees= {rad} radian Sine=  {cosValue}");
                Thread.Sleep(100);
            }

        }

        public static void displayMessage()
        {
            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine("Hello Message from Simran");
                Thread.Sleep(10);
            }
        }
    }
}
