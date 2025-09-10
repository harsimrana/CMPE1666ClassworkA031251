namespace Demo02w2day2Sep10_controls
{
    partial class Demo02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Start_Btn = new System.Windows.Forms.Button();
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Transfer_Btn = new System.Windows.Forms.Button();
            this.UI_Input1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Input2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sum_Btn = new System.Windows.Forms.Button();
            this.UI_Screen_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Display_Lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_Display_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_Display_Lbl.MinimumSize = new System.Drawing.Size(300, 20);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Padding = new System.Windows.Forms.Padding(20);
            this.UI_Display_Lbl.Size = new System.Drawing.Size(300, 61);
            this.UI_Display_Lbl.TabIndex = 0;
            this.UI_Display_Lbl.Text = "0";
            // 
            // UI_Start_Btn
            // 
            this.UI_Start_Btn.Location = new System.Drawing.Point(12, 95);
            this.UI_Start_Btn.Name = "UI_Start_Btn";
            this.UI_Start_Btn.Size = new System.Drawing.Size(300, 58);
            this.UI_Start_Btn.TabIndex = 1;
            this.UI_Start_Btn.Text = "Start";
            this.UI_Start_Btn.UseVisualStyleBackColor = true;
            this.UI_Start_Btn.Click += new System.EventHandler(this.UI_Start_Btn_Click);
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_Input_Tbx.Location = new System.Drawing.Point(343, 9);
            this.UI_Input_Tbx.MinimumSize = new System.Drawing.Size(300, 20);
            this.UI_Input_Tbx.Multiline = true;
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(300, 61);
            this.UI_Input_Tbx.TabIndex = 2;
            // 
            // UI_Transfer_Btn
            // 
            this.UI_Transfer_Btn.BackColor = System.Drawing.Color.RosyBrown;
            this.UI_Transfer_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UI_Transfer_Btn.Location = new System.Drawing.Point(343, 95);
            this.UI_Transfer_Btn.Name = "UI_Transfer_Btn";
            this.UI_Transfer_Btn.Size = new System.Drawing.Size(300, 58);
            this.UI_Transfer_Btn.TabIndex = 3;
            this.UI_Transfer_Btn.Text = "Transfer Text";
            this.UI_Transfer_Btn.UseVisualStyleBackColor = false;
            this.UI_Transfer_Btn.Click += new System.EventHandler(this.UI_Transfer_Btn_Click);
            // 
            // UI_Input1_Tbx
            // 
            this.UI_Input1_Tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_Input1_Tbx.Location = new System.Drawing.Point(12, 206);
            this.UI_Input1_Tbx.MinimumSize = new System.Drawing.Size(300, 20);
            this.UI_Input1_Tbx.Multiline = true;
            this.UI_Input1_Tbx.Name = "UI_Input1_Tbx";
            this.UI_Input1_Tbx.Size = new System.Drawing.Size(300, 61);
            this.UI_Input1_Tbx.TabIndex = 4;
            // 
            // UI_Input2_Tbx
            // 
            this.UI_Input2_Tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_Input2_Tbx.Location = new System.Drawing.Point(343, 206);
            this.UI_Input2_Tbx.MinimumSize = new System.Drawing.Size(300, 20);
            this.UI_Input2_Tbx.Multiline = true;
            this.UI_Input2_Tbx.Name = "UI_Input2_Tbx";
            this.UI_Input2_Tbx.Size = new System.Drawing.Size(300, 61);
            this.UI_Input2_Tbx.TabIndex = 5;
            // 
            // UI_Sum_Btn
            // 
            this.UI_Sum_Btn.Location = new System.Drawing.Point(12, 293);
            this.UI_Sum_Btn.Name = "UI_Sum_Btn";
            this.UI_Sum_Btn.Size = new System.Drawing.Size(140, 58);
            this.UI_Sum_Btn.TabIndex = 6;
            this.UI_Sum_Btn.Text = "Sum";
            this.UI_Sum_Btn.UseVisualStyleBackColor = true;
            this.UI_Sum_Btn.Click += new System.EventHandler(this.UI_Sum_Btn_Click);
            // 
            // UI_Screen_Lbl
            // 
            this.UI_Screen_Lbl.AutoSize = true;
            this.UI_Screen_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Screen_Lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_Screen_Lbl.Location = new System.Drawing.Point(12, 380);
            this.UI_Screen_Lbl.MinimumSize = new System.Drawing.Size(650, 20);
            this.UI_Screen_Lbl.Name = "UI_Screen_Lbl";
            this.UI_Screen_Lbl.Padding = new System.Windows.Forms.Padding(20);
            this.UI_Screen_Lbl.Size = new System.Drawing.Size(650, 61);
            this.UI_Screen_Lbl.TabIndex = 7;
            this.UI_Screen_Lbl.Text = "0";
            // 
            // Demo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.UI_Screen_Lbl);
            this.Controls.Add(this.UI_Sum_Btn);
            this.Controls.Add(this.UI_Input2_Tbx);
            this.Controls.Add(this.UI_Input1_Tbx);
            this.Controls.Add(this.UI_Transfer_Btn);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Controls.Add(this.UI_Start_Btn);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Demo02";
            this.Text = "Demo 02";
            this.Load += new System.EventHandler(this.Demo02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.Button UI_Start_Btn;
        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.Button UI_Transfer_Btn;
        private System.Windows.Forms.TextBox UI_Input1_Tbx;
        private System.Windows.Forms.TextBox UI_Input2_Tbx;
        private System.Windows.Forms.Button UI_Sum_Btn;
        private System.Windows.Forms.Label UI_Screen_Lbl;
    }
}

