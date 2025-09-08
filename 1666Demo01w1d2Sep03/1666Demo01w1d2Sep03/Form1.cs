using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1666Demo01w1d2Sep03
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login button clicked");
            System.Diagnostics.Trace.WriteLine("Login Button Clicked Message from Trace");

            // Changing the title of the form on the click of Login button
            Text = "Login Form";
        }

        // Object sender is a reference to the object that sent the event

        // EventArgs e is an object that contains additional data about the event
        private void LoginForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form is loaded");
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(" Form is shown on screen");
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(" Paint event occcured");
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"Form is closing {e.CloseReason} " );
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //e.Cancel= true;  // Preventing user from closing the form
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"Form is closed {e.CloseReason} ");
        }

        private void LoginForm_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen; 
        }

        private void LoginForm_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }
    }
}
