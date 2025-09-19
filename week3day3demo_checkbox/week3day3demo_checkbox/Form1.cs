using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3day3demo_checkbox
{
    public partial class Form1 : Form
    {
        double item1Cost = 0, item2Cost = 0;
        bool gstCheckBoxState;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_TotalCost_Btn_Click(object sender, EventArgs e)
        {
            gstCheckBoxState = UI_GST_Cbx.Checked;

            item1Cost = ConvertToDouble(UI_Item1Cost_Tbx.Text);
            item2Cost = ConvertToDouble(UI_Item2Cost_Tbx.Text);

            if(item1Cost !=0 && item2Cost != 0)
                CalculateTotalCost(item1Cost, item2Cost, gstCheckBoxState);
        }

        private void UI_GST_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            gstCheckBoxState = UI_GST_Cbx.Checked;


            item1Cost = ConvertToDouble(UI_Item1Cost_Tbx.Text);
            item2Cost = ConvertToDouble(UI_Item2Cost_Tbx.Text);
            
            if (item1Cost != 0 && item2Cost != 0)
                CalculateTotalCost(item1Cost, item2Cost, gstCheckBoxState);
            CalculateTotalCost(double.Parse(UI_Item1Cost_Tbx.Text), double.Parse(UI_Item2Cost_Tbx.Text), UI_GST_Cbx.Checked);
        }
        // Funciton to parse value to double

        public double ConvertToDouble(string value)
        {
            try
            {
                return double.Parse(value);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Not a valid value" + e.Message);
                return 0;
            }
        }

        // Function to calculate total
        public void CalculateTotalCost(double item1Cost, double item2Cost, bool IsGSTRequired) 
        {
            double sumOfItems = item1Cost + item2Cost;
            double gstCharged = sumOfItems * 0.05;

            sumOfItems = sumOfItems + (IsGSTRequired == true ? gstCharged : 0);

            UI_TotalCost_Tbx.Text = sumOfItems.ToString();
        }
    }
}
