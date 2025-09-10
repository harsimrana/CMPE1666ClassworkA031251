using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02w2day2Sep10_controls
{
    public partial class Demo02 : Form
    {
        int count = 0; // Variable count to keep track of number of clicks
        public Demo02()
        {
            InitializeComponent();
        }

        private void Demo02_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form is loaded");
        }

        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(" Start button is clicked");
            // Change the title of your form to something nice of your choice
            // keyword this refers to current form 
            this.Text = "Demo 02 Form";

            if (count < 10)
            {

                System.Diagnostics.Trace.WriteLine($"{count}");
                count++;
                // string.Format() can perform complex formatting 
                string displayMessage = string.Format(" Button is clicked {0} times", count);

                // Version 2: String Interpolation
                string displayMessage1 = $" Button is clicked {count} times";

                // UI_Display_Lbl.Text = "Button is clicked "+ count.ToString() + " Times.";  //ToString() - to covert the value into a string

                UI_Display_Lbl.Text = displayMessage1;
            }
            else
            {
                UI_Display_Lbl.ForeColor = Color.Red;
                UI_Display_Lbl.Text = $" Button is clicked {count} times. You won't be able to do it now.";
            }
        }

        private void UI_Transfer_Btn_Click(object sender, EventArgs e)
        {
            // Debugging part : Where, What event, Date
            System.Diagnostics.Trace.WriteLine(" Transfer button is clicked " + DateTime.Now.ToString());

            /*
             *  Take the text from Text Box and show it on label 
             *  Then, emply your text box
             */

            if (UI_Input_Tbx.Text.ToString().Length > 0)
            {
                UI_Input_Tbx.ForeColor = Color.White;
                UI_Input_Tbx.BackColor = Color.Green;

                UI_Display_Lbl.Text = UI_Input_Tbx.Text;  // Copying the text from textbox to label

                UI_Input_Tbx.Text = String.Empty; // or "" empty string  Making text box empty

            }
            else {

                // TO TEST THIS UNCOMMENT THE FOLLOWING
                //UI_Input_Tbx.ForeColor = Color.White;
                //UI_Input_Tbx.BackColor = Color.Red;
                // Give a warning message
                //UI_Input_Tbx.Text = "You cannot leave it empty";

                // Give a pop up message for warning

                // MessageBox is not a control, it is used to displayed error/warning messages to user
                MessageBox.Show("You cannot leave text box empty");
            }
            
            /*
             * Make changes to this program:
             * 1. Make sure Text box string should not be empty 
             * 2. Try to change the background and foreground color [your choice] label and/or textbox 
             * */
        }

        private void UI_Sum_Btn_Click(object sender, EventArgs e)
        {
            // Grab text from textbox 1, textbox 2
            // Perform addition
            // Show the result on screen label
            int result = int.Parse(UI_Input1_Tbx.Text) + int.Parse(UI_Input2_Tbx.Text);

            UI_Screen_Lbl.Text = result.ToString();

        }
    }
}
