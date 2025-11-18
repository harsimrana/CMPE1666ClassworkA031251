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
    public partial class ModalDialogUserForm : Form
    {
        public ModalDialogUserForm()
        {
            InitializeComponent();
            UI_Tbx_InputUsername.Text = "Simran";
        }

        private void UI_Btn_OK_Click(object sender, EventArgs e)
        {   // This will cause the form to close and return the
            // value DiagloResul.OK to the caller,
            // you can use that value in the caller method to decide
            DialogResult = DialogResult.OK;            

        }

        public string getUserName()
        {
            Console.WriteLine($"Inside GetUsername method {UI_Tbx_InputUsername.Text}");
            return UI_Tbx_InputUsername.Text;
        }

        private void UI_Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
