namespace StudentManagerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.UI_StName_TBX = new System.Windows.Forms.TextBox();
            this.UI_StMarks_TBX = new System.Windows.Forms.TextBox();
            this.UI_StEmail_TBX = new System.Windows.Forms.TextBox();
            this.UI_StAge_TBX = new System.Windows.Forms.TextBox();
            this.UI_ListIndex_TBX = new System.Windows.Forms.TextBox();
            this.UI_AddSt_BTN = new System.Windows.Forms.Button();
            this.UI_RemoveSt_BTN = new System.Windows.Forms.Button();
            this.UI_InsertAtIndex_BTN = new System.Windows.Forms.Button();
            this.UI_ClearSt_BTN = new System.Windows.Forms.Button();
            this.UI_Students_LST = new System.Windows.Forms.ListBox();
            this.UI_StName_Lb = new System.Windows.Forms.Label();
            this.UI_StMarks_Lb = new System.Windows.Forms.Label();
            this.UI_StEmail_Lb = new System.Windows.Forms.Label();
            this.UI_StAge_Lb = new System.Windows.Forms.Label();
            this.UI_IndexPSN_Lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_StName_TBX
            // 
            this.UI_StName_TBX.Location = new System.Drawing.Point(145, 20);
            this.UI_StName_TBX.Name = "UI_StName_TBX";
            this.UI_StName_TBX.Size = new System.Drawing.Size(200, 22);
            this.UI_StName_TBX.TabIndex = 0;
            // 
            // UI_StMarks_TBX
            // 
            this.UI_StMarks_TBX.Location = new System.Drawing.Point(145, 60);
            this.UI_StMarks_TBX.Name = "UI_StMarks_TBX";
            this.UI_StMarks_TBX.Size = new System.Drawing.Size(200, 22);
            this.UI_StMarks_TBX.TabIndex = 1;
            // 
            // UI_StEmail_TBX
            // 
            this.UI_StEmail_TBX.Location = new System.Drawing.Point(145, 100);
            this.UI_StEmail_TBX.Name = "UI_StEmail_TBX";
            this.UI_StEmail_TBX.Size = new System.Drawing.Size(200, 22);
            this.UI_StEmail_TBX.TabIndex = 2;
            // 
            // UI_StAge_TBX
            // 
            this.UI_StAge_TBX.Location = new System.Drawing.Point(145, 140);
            this.UI_StAge_TBX.Name = "UI_StAge_TBX";
            this.UI_StAge_TBX.Size = new System.Drawing.Size(200, 22);
            this.UI_StAge_TBX.TabIndex = 3;
            // 
            // UI_ListIndex_TBX
            // 
            this.UI_ListIndex_TBX.Location = new System.Drawing.Point(145, 180);
            this.UI_ListIndex_TBX.Name = "UI_ListIndex_TBX";
            this.UI_ListIndex_TBX.Size = new System.Drawing.Size(200, 22);
            this.UI_ListIndex_TBX.TabIndex = 4;
            // 
            // UI_AddSt_BTN
            // 
            this.UI_AddSt_BTN.Location = new System.Drawing.Point(372, 16);
            this.UI_AddSt_BTN.Name = "UI_AddSt_BTN";
            this.UI_AddSt_BTN.Size = new System.Drawing.Size(150, 30);
            this.UI_AddSt_BTN.TabIndex = 5;
            this.UI_AddSt_BTN.Text = "Add Student";
            this.UI_AddSt_BTN.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UI_RemoveSt_BTN
            // 
            this.UI_RemoveSt_BTN.Location = new System.Drawing.Point(372, 56);
            this.UI_RemoveSt_BTN.Name = "UI_RemoveSt_BTN";
            this.UI_RemoveSt_BTN.Size = new System.Drawing.Size(150, 30);
            this.UI_RemoveSt_BTN.TabIndex = 6;
            this.UI_RemoveSt_BTN.Text = "Remove Student";
            this.UI_RemoveSt_BTN.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UI_InsertAtIndex_BTN
            // 
            this.UI_InsertAtIndex_BTN.Location = new System.Drawing.Point(372, 96);
            this.UI_InsertAtIndex_BTN.Name = "UI_InsertAtIndex_BTN";
            this.UI_InsertAtIndex_BTN.Size = new System.Drawing.Size(150, 30);
            this.UI_InsertAtIndex_BTN.TabIndex = 7;
            this.UI_InsertAtIndex_BTN.Text = "Insert at Index";
            this.UI_InsertAtIndex_BTN.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // UI_ClearSt_BTN
            // 
            this.UI_ClearSt_BTN.Location = new System.Drawing.Point(372, 136);
            this.UI_ClearSt_BTN.Name = "UI_ClearSt_BTN";
            this.UI_ClearSt_BTN.Size = new System.Drawing.Size(150, 30);
            this.UI_ClearSt_BTN.TabIndex = 8;
            this.UI_ClearSt_BTN.Text = "Clear All Students";
            this.UI_ClearSt_BTN.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UI_Students_LST
            // 
            this.UI_Students_LST.FormattingEnabled = true;
            this.UI_Students_LST.ItemHeight = 16;
            this.UI_Students_LST.Location = new System.Drawing.Point(27, 220);
            this.UI_Students_LST.Name = "UI_Students_LST";
            this.UI_Students_LST.Size = new System.Drawing.Size(495, 212);
            this.UI_Students_LST.TabIndex = 9;
            // 
            // UI_StName_Lb
            // 
            this.UI_StName_Lb.Location = new System.Drawing.Point(24, 23);
            this.UI_StName_Lb.Name = "UI_StName_Lb";
            this.UI_StName_Lb.Size = new System.Drawing.Size(125, 29);
            this.UI_StName_Lb.TabIndex = 10;
            this.UI_StName_Lb.Text = "Student Name";
            // 
            // UI_StMarks_Lb
            // 
            this.UI_StMarks_Lb.Location = new System.Drawing.Point(24, 60);
            this.UI_StMarks_Lb.Name = "UI_StMarks_Lb";
            this.UI_StMarks_Lb.Size = new System.Drawing.Size(125, 29);
            this.UI_StMarks_Lb.TabIndex = 11;
            this.UI_StMarks_Lb.Text = "Student Marks";
            // 
            // UI_StEmail_Lb
            // 
            this.UI_StEmail_Lb.Location = new System.Drawing.Point(24, 100);
            this.UI_StEmail_Lb.Name = "UI_StEmail_Lb";
            this.UI_StEmail_Lb.Size = new System.Drawing.Size(125, 29);
            this.UI_StEmail_Lb.TabIndex = 12;
            this.UI_StEmail_Lb.Text = "Student Email";
            // 
            // UI_StAge_Lb
            // 
            this.UI_StAge_Lb.Location = new System.Drawing.Point(24, 137);
            this.UI_StAge_Lb.Name = "UI_StAge_Lb";
            this.UI_StAge_Lb.Size = new System.Drawing.Size(125, 29);
            this.UI_StAge_Lb.TabIndex = 13;
            this.UI_StAge_Lb.Text = "Student Age";
            // 
            // UI_IndexPSN_Lb
            // 
            this.UI_IndexPSN_Lb.Location = new System.Drawing.Point(24, 173);
            this.UI_IndexPSN_Lb.Name = "UI_IndexPSN_Lb";
            this.UI_IndexPSN_Lb.Size = new System.Drawing.Size(125, 29);
            this.UI_IndexPSN_Lb.TabIndex = 14;
            this.UI_IndexPSN_Lb.Text = "Insert Index";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.UI_IndexPSN_Lb);
            this.Controls.Add(this.UI_StAge_Lb);
            this.Controls.Add(this.UI_StEmail_Lb);
            this.Controls.Add(this.UI_StMarks_Lb);
            this.Controls.Add(this.UI_StName_Lb);
            this.Controls.Add(this.UI_StName_TBX);
            this.Controls.Add(this.UI_StMarks_TBX);
            this.Controls.Add(this.UI_StEmail_TBX);
            this.Controls.Add(this.UI_StAge_TBX);
            this.Controls.Add(this.UI_ListIndex_TBX);
            this.Controls.Add(this.UI_AddSt_BTN);
            this.Controls.Add(this.UI_RemoveSt_BTN);
            this.Controls.Add(this.UI_InsertAtIndex_BTN);
            this.Controls.Add(this.UI_ClearSt_BTN);
            this.Controls.Add(this.UI_Students_LST);
            this.Name = "Form1";
            this.Text = "Student Manager App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_StName_TBX;
        private System.Windows.Forms.TextBox UI_StMarks_TBX;
        private System.Windows.Forms.TextBox UI_StEmail_TBX;
        private System.Windows.Forms.TextBox UI_StAge_TBX;
        private System.Windows.Forms.TextBox UI_ListIndex_TBX;
        private System.Windows.Forms.Button UI_AddSt_BTN;
        private System.Windows.Forms.Button UI_RemoveSt_BTN;
        private System.Windows.Forms.Button UI_InsertAtIndex_BTN;
        private System.Windows.Forms.Button UI_ClearSt_BTN;
        private System.Windows.Forms.ListBox UI_Students_LST;
        private System.Windows.Forms.Label UI_StName_Lb;
        private System.Windows.Forms.Label UI_StMarks_Lb;
        private System.Windows.Forms.Label UI_StEmail_Lb;
        private System.Windows.Forms.Label UI_StAge_Lb;
        private System.Windows.Forms.Label UI_IndexPSN_Lb;
    }
}

