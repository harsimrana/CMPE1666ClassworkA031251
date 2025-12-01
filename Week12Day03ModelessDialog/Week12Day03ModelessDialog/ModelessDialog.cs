using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Day03ModelessDialog
{
    //Delegate for sending notifications to the main form

    public delegate void delVoidString(string s);
    public delegate void delVoidVoid();

    public partial class ModelessDialog : Form
    {
        // delegate reference will contain the callback function
        public delVoidString _dTextChanged = null;

        public delVoidVoid _dFormClosing = null;
        public ModelessDialog()
        {
            InitializeComponent();
        }

        private void UI_Tbx_input_TextChanged(object sender, EventArgs e)
        {
            // When the text is changed in the textbox, the callback method is invoked
            // to update the label on the main form 

            if (_dTextChanged != null)
            {
                // _dTextChanged.Invoke( UI_Tbx_input.Text );
                // Shortcut to call method 
                _dTextChanged(UI_Tbx_input.Text);
            }


            //MessageBox.Show(UI_Tbx_input.Text.Length.ToString());
        }

        private void ModelessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // usually X button will normally close the dialog and dispose off it from memory
            // Here we just want to hide it instead of closing it.
            // So we will try to intercept the form closing event, check the reason, and override the close one with hide
            // Dialog being closed by user ? Then do not close it, hide it
            if (e.CloseReason == CloseReason.UserClosing)
            {

                // check to ensure that delegate reference is present

                if (_dFormClosing != null)
                {
                    _dFormClosing(); // Calling callback function in Main form
                }
                //stop the close from happening
                e.Cancel = true;

                // hide the dialog
                Hide();
            }
        }
    }
}
