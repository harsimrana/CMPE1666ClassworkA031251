using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13Day03Demo02MultiThreading
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_btn_CountClick_Click(object sender, EventArgs e)
        {
            UI_lbl_Count.Text = $" Button has been clicked {++count} times";
        }

        public void FindSine()
        {
            for (double x = 0; x < 180; x += 1)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");
                UI_lbx_SinValues.Items.Add($" {x} degrees= {rad} radian = Cos = {sineValue}");
                Thread.Sleep(100);
                Console.WriteLine($" {x} degrees= {rad} radian = Cos = {sineValue}");
            }

        }

        private void UI_btn_Calculate_Click(object sender, EventArgs e)
        {
            FindSine();
        }
    }
}
