using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Day01ModalDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Modal Dialogs : Used to gather data from user
         * Modal and Modalless 
         * Modal Dialog steals focus from the main form until user is going to perform action: clicking any button
         * Modaless dialog stays on the screen and allows the main form to retain the focus
         * 
         */

        /* 
         * We can create our own one as well 
         * How??
         * Project -> Add new Item -> windows form -> Forms windod forms
         * Provide name and press ok
         * 
         */

        private void UI_Btn_Message_Click(object sender, EventArgs e)
        {   //              Message                    Caption         Buttons 
            //MessageBox.Show("Button has been clicked ", "Display Box", MessageBoxButtons.YesNoCancel);

            // Instead of using MessageBox, I want to open my own ModalDialogUserForm
            // Creating object of our ModalDialogUserForm class
            ModalDialogUserForm dialog = new ModalDialogUserForm();

            //dialog.Show(); //modeless one

            // Show the Dialog using ShowDialog()
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Ok button was pressed on dialog");
                // Place your code here to handle the result from the dialog 
                // It is not possible to targer any control [Properties/event] from another 
                // Class directly here


                //UI_Tbx_InputUsername.Text 

                // We need something to pass values from one form to another
                // You can public method in another class

                Console.WriteLine($" Inside Main form {dialog.getUserName()}");
                string username = dialog.getUserName();
                //validation 
                if (username.Length > 0)
                { 
                    // Compare username or anything else you want to do
                }
            }
            else
            {
             //   MessageBox.Show("Dialog was closed with Cancel or X button");
            }

        }

        
    }
}
