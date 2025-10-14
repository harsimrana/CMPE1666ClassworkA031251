using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week07Day01DemoDragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Drag Enter event listener : To give visually impression to user that this control will accept drag and drop feature
        private void UI_Lbl_DragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent( DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void UI_Lbl_DragDrop_DragDrop(object sender, DragEventArgs e)
        {
            // try -catch block to handle it carefully

            // Getting the path of the file
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            Console.WriteLine(filePath);

            string[] fileData = File.ReadAllLines(filePath);

            // Add data read from file into your list
            foreach (string line in fileData)
            {
                UI_Lbx_FileData.Items.Add(line);
            }

        }
    }
}
