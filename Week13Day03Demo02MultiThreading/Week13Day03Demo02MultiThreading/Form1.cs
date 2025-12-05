using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
  Generic delegate types
   : to avoid us the task of creating a new custom delegate type
   Action :  zero or more input arguments and no output
             void  delegate ( int a, string str)
   Func :  zero or more input arguments and one output argument [return type]
       


    Terminating a Thread
     Sometimes if a thread is taking too long, you may want to have a way to terminate it,
    even when main thread continues to run

    Easiest way to do that is to have boolean class variable that we will set to true initially 
    and then inside thread we will check the value of that variable and execute only if that variable is 
    true. 
    we can give user another control for example button click that will change the variable to false


    ParamerterizedThreadStart
    Threads created by (implicit or explicit ) use of ThreadStart, delegate cannot have parameters
    -> you can not pass data to the thread

    Data can be passed to a thread as type object by using the ParametherizedThreadStart delegate

    Data to be passed to thread will be provided as an argument to start()
    
    The data will be boxed to an object type

    The will be unboxed in the Thread 

 */
namespace Week13Day03Demo02MultiThreading
{
    public partial class Form1 : Form
    {
        struct Boundaries
        {
            public int Min;
            public int Max;

            public Boundaries(int minValue, int maxValue)
            {
                Min = minValue;
                Max = maxValue;
            }

        }

        private int count = 0;

        Thread t1 = null, t2 = null, t3 = null;

        bool runThread = true; // Defined in the class to control thread

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_btn_CountClick_Click(object sender, EventArgs e)
        {
            UI_lbl_Count.Text = $" Button has been clicked {++count} times";
        }

        public void FindSine()
        {
            // Creating an action delegate 
            Action<string> delWriteSine = AddToListBox;

            double x = 0;

            while ( (x < 180) && (runThread==true)  )
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");
                // you can note that trying to access the listbox from the newly created thread causes
                // an exception 
                // To avoid that we can use delegates
                string str = $" {x} degrees= {rad} radian = Cos = {sineValue}";
                try
                {
                    //use Involke method to access AddToListBox from form class
                    Invoke(delWriteSine, str);

                }
                catch(Exception e)
                {
                    Console.WriteLine("Delegate can be invoked");

                }
                //UI_lbx_SinValues.Items.Add($" {x} degrees= {rad} radian = Cos = {sineValue}");
                Thread.Sleep(100);
                Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");

                x += 1;
            }

        }

        // handling one value passed from form/thread
        public void FindSine1(object argument)
        {
            // Creating an action delegate 
            Action<string> delWriteSine = AddToListBox;

            double x = 0;
            if (argument is int maxDegree)
            {
                // Also possible to unbox regular types
                //int maxDegree = (int) argument;
                while ((x <= maxDegree) && (runThread == true))
                {
                    double rad = Math.PI * x / 180;
                    double sineValue = Math.Sin(rad);
                    Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");
                    // you can note that trying to access the listbox from the newly created thread causes
                    // an exception 
                    // To avoid that we can use delegates
                    string str = $" {x} degrees= {rad} radian = Cos = {sineValue}";
                    try
                    {
                        //use Involke method to access AddToListBox from form class
                        Invoke(delWriteSine, str);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Delegate can be invoked");

                    }
                    //UI_lbx_SinValues.Items.Add($" {x} degrees= {rad} radian = Cos = {sineValue}");
                    Thread.Sleep(100);
                    Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");

                    x += 1;
                }
            }

        }

        // Handling struct passed from main form/thread
        public void FindSine2(object argument)
        {
            // Creating an action delegate 
            Action<string> delWriteSine = AddToListBox;

            //  Func
            if (argument is Boundaries )
            { // Checking the value is of expected type

                // Unboxed the boundaries object
                Boundaries b2 = (Boundaries)argument;

                double x = b2.Min;  // Accessing the value of MIN member

                while ((x <= b2.Max) && (runThread == true))
                {
                    double rad = Math.PI * x / 180;
                    double sineValue = Math.Sin(rad);
                    Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");
                    // you can note that trying to access the listbox from the newly created thread causes
                    // an exception 
                    // To avoid that we can use delegates
                    string str = $" {x} degrees= {rad} radian = Cos = {sineValue}";
                    try
                    {
                        //use Involke method to access AddToListBox from form class
                        Invoke(delWriteSine, str);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Delegate can be invoked");

                    }
                    //UI_lbx_SinValues.Items.Add($" {x} degrees= {rad} radian = Cos = {sineValue}");
                    Thread.Sleep(100);
                    Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");

                    x += 1;
                }
            }

        }

        private void AddToListBox(string str )
        {
            // Add the string to the list box
            UI_lbx_SinValues.Items.Add(str);

        }
        private void UI_btn_Calculate_Click(object sender, EventArgs e)
        {
            //t1 = new Thread( FindSine );
            // ThreadStart() is present by default
            //t1 = new Thread( new ThreadStart(FindSine) );
            // By default all the threads run in foreground
            // you can change the thread to background  by controlling isBackground property
            //t1.IsBackground = true;
            //runThread = true;
            // using start thread start your thread
            //t1.Start( );

            // UNCOMMENT THE FOLLOWING SECTION to test the thread by passing one value from main Thread
            //t2 = new Thread(new ParameterizedThreadStart(FindSine1));
            //t2.Name = "FindSine(90)";

            //t2.Start(90);

            t3 = new Thread(new ParameterizedThreadStart(FindSine2));

            t3.Name = "FindSine2 handling Struct";
            // Create an object of Struct type 
            Boundaries b1 = new Boundaries(91, 180);

            t3.Start( b1 );

            Console.WriteLine($" The Thread state is = {t3.ThreadState.ToString()}");

            //Thread states: running, stopped, suspended, Aborted, bacground 

            if (t3.ThreadState == ThreadState.Running)
            {
                Console.WriteLine("The Thread is running");
                
            }
            //FindSine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Change the value of runThread variable to false to stop the thread
            runThread = false;

            Console.WriteLine($" The Thread state is = {t3.ThreadState.ToString()}");

        }
    }
}
