using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagerApp
{
    public partial class Form1 : Form
    {
        // Define struct to store student information
        public struct Student
        {
            public string StudentName;
            public double StudentMarks;
            public string StudentEmail;
            public int StudentAge;

            public override string ToString()
            {
                return $"{StudentName}, Marks: {StudentMarks}, Age: {StudentAge}, Email: {StudentEmail}";
            }
        }

        // List to hold students
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {   
                // Validation is pending for non text values
                Student s = new Student
                {
                    StudentName = UI_StName_TBX.Text,
                    StudentMarks = double.Parse(UI_StMarks_TBX.Text),
                    StudentEmail = UI_StEmail_TBX.Text,
                    StudentAge = int.Parse(UI_StAge_TBX.Text)
                };
                students.Add(s);
                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (UI_Students_LST.SelectedIndex >= 0)
            {
                students.RemoveAt(UI_Students_LST.SelectedIndex);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Select a student to remove.");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Validation is pending for invalid value
                int index = int.Parse(UI_ListIndex_TBX.Text);
                
                // Validating index for current range
                if (index >= 0 && index <= students.Count)
                {
                    Student s = new Student
                    {
                        StudentName = UI_StName_TBX.Text,
                        StudentMarks = double.Parse(UI_StMarks_TBX.Text),
                        StudentEmail = UI_StEmail_TBX.Text,
                        StudentAge = int.Parse(UI_StAge_TBX.Text)
                    };
                    students.Insert(index, s);
                    RefreshList();
                }
                else
                {
                    MessageBox.Show("Invalid index.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            students.Clear();
            RefreshList();
        }

        // Method to refresh student list
        private void RefreshList()
        {
            UI_Students_LST.Items.Clear();
            foreach (var s in students)
            {
                UI_Students_LST.Items.Add(s.ToString());
            }
        }
    }
}
