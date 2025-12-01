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
    public partial class UI_MainForm : Form
    {
        ModelessDialog dlg = null;
        public UI_MainForm()
        {
            InitializeComponent();
        }
        // MAIN PLAN
        /* Use delegated with modeless Dialogs
         * -- Main Form
         * -- Modeless Dialog Form
         *    -- Text box so that user input text. As the user is going to type the text, text will show in the main form
         * -- checkbox Main Form: Check will open the Modeless Dialog    
         */

        private void CallBackTextChanged(string str)
        {
            UI_Lbl_DialogText.Text = str;
        }

        // When the checkbox is checked for the first time,
        // the modeless dialog is creted and shown
        // Subsequently, whenever the checkbox is checked the dialog is shown
        // when the checkbox is unchecked the dialog is hidden
        private void UI_ShowDialog_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowDialog_Cbx.Checked)
            {
                if (dlg == null)
                {
                    dlg = new ModelessDialog();
                    dlg._dTextChanged = CallBackTextChanged;
                    dlg._dFormClosing = CallBackFormClosing;

                }
                dlg.Show();
            }
            else
            {
                dlg.Hide();
            }
            


        }

        private void CallBackFormClosing()
        {
            UI_ShowDialog_Cbx.Checked = false;
            // No need of this now because this part has been handled in ModelessDialog.cs file

            //dlg = null;  // Need to reset back to null so that if [dlg == null] part works
            // CallBackTextChanged("");   // if you need to clear text of label as well
        }
    }
}
