using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demow3day116septimersstopwatch
{
    public partial class Form1 : Form
    {
        // count variable to track timer
        int count = 0;

        // Create an object of stopwatch 
        Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();
        // System.Diagnostics is option if namespace is already added at the top
        public Form1()
        {
            InitializeComponent();

            UI_timer1.Enabled = true; // It will start your timer
        }

        private void UI_timer1_Tick(object sender, EventArgs e)
        {
            // Simple message in output window
            System.Diagnostics.Trace.WriteLine("Message from timer");
            // increase the count and display the value on label

            count++; // Increase count

            // Update your label
            // Text property is expecting a string value
            //UI_Screen_Lb.Text = count.ToString();  // Make sure to convert it into string

            UI_Screen_Lb.Text = $" Count : {count}";

            // display number of milliseconds elapsed/passed in textbox
            // ElapsedMilliseconds of stopwatch object will give you that number
            UI_Time_Tbx.Text = myStopWatch.ElapsedMilliseconds.ToString();


            // If count variable reaches a multiple of 3 the value is added to 
            // the list

            if (count % 3 == 0)  // checking the logic for multiple of 3
            {
                // Adding the value of count to list items
                UI_List_Lbx.Items.Add(count);  
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Inside Form load");
            myStopWatch.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stoping my stopwatch
            myStopWatch.Stop();

            // Disable the timer by changing the Enabled property to false
            UI_timer1.Enabled = false;

            // Clear list items - Remove all items from the list
            UI_List_Lbx.Items.Clear();
            //UI_List_Lbx.Items.Remove(3);
            //UI_List_Lbx.Items.RemoveAt(1); // Index starts from 0 like arrays


            // RemoveAt () - will remove an item at specific position
            // Remove()    - will remove item from the list
        }
    }
}
