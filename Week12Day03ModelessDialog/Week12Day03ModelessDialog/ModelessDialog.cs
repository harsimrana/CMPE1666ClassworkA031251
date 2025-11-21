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
    public partial class ModelessDialog : Form
    {
        // delegate reference will contain the callback function
        public delVoidString _dTextChanged = null;
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
    }
}
