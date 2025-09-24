using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4day2demo0124092025radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Now we can observe one single event handler is linked to both radio buttons
        // You can see 2 references added here
        private void Radio_CheckedChanged(object sender, EventArgs e)
        { 
            if(UI_Red_RB.Checked)
            {
                UI_Color_TB.BackColor = Color.Red;
            }
            if (UI_Blue_RB.Checked)
            {
                UI_Color_TB.BackColor = Color.Blue;
            }
        }
        /*
   Instead of using separate event handler for each radio button in a group
   it is better we can use one event handler- Event Consolidation
*/
        /*
        private void UI_Red_RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UI_Blue_RB_CheckedChanged(object sender, EventArgs e)
        {

        }
        */

        /*
         * Radio button: one can be checked at a time
         * Checked property to know whether it's checked or not
         * Event : CheckedChanged
         * Need to group under a GroupBox -> containers
         */
    }
}
