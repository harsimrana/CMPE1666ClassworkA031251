namespace week4day2demo0124092025radio
{
    partial class Form1
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
            this.UI_ColorType_GB = new System.Windows.Forms.GroupBox();
            this.UI_Red_RB = new System.Windows.Forms.RadioButton();
            this.UI_Blue_RB = new System.Windows.Forms.RadioButton();
            this.UI_Color_TB = new System.Windows.Forms.TextBox();
            this.UI_ColorType_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_ColorType_GB
            // 
            this.UI_ColorType_GB.Controls.Add(this.UI_Blue_RB);
            this.UI_ColorType_GB.Controls.Add(this.UI_Red_RB);
            this.UI_ColorType_GB.Location = new System.Drawing.Point(44, 74);
            this.UI_ColorType_GB.Name = "UI_ColorType_GB";
            this.UI_ColorType_GB.Size = new System.Drawing.Size(200, 100);
            this.UI_ColorType_GB.TabIndex = 0;
            this.UI_ColorType_GB.TabStop = false;
            this.UI_ColorType_GB.Text = "Pick Color";
            // 
            // UI_Red_RB
            // 
            this.UI_Red_RB.AutoSize = true;
            this.UI_Red_RB.Location = new System.Drawing.Point(16, 33);
            this.UI_Red_RB.Name = "UI_Red_RB";
            this.UI_Red_RB.Size = new System.Drawing.Size(48, 17);
            this.UI_Red_RB.TabIndex = 0;
            this.UI_Red_RB.Text = "RED";
            this.UI_Red_RB.UseVisualStyleBackColor = true;
            this.UI_Red_RB.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // UI_Blue_RB
            // 
            this.UI_Blue_RB.AutoSize = true;
            this.UI_Blue_RB.Checked = true;
            this.UI_Blue_RB.Location = new System.Drawing.Point(16, 66);
            this.UI_Blue_RB.Name = "UI_Blue_RB";
            this.UI_Blue_RB.Size = new System.Drawing.Size(46, 17);
            this.UI_Blue_RB.TabIndex = 1;
            this.UI_Blue_RB.TabStop = true;
            this.UI_Blue_RB.Text = "Blue";
            this.UI_Blue_RB.UseVisualStyleBackColor = true;
            this.UI_Blue_RB.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // UI_Color_TB
            // 
            this.UI_Color_TB.ForeColor = System.Drawing.SystemColors.Window;
            this.UI_Color_TB.Location = new System.Drawing.Point(441, 137);
            this.UI_Color_TB.Multiline = true;
            this.UI_Color_TB.Name = "UI_Color_TB";
            this.UI_Color_TB.ReadOnly = true;
            this.UI_Color_TB.Size = new System.Drawing.Size(277, 37);
            this.UI_Color_TB.TabIndex = 1;
            this.UI_Color_TB.Text = "Color Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Color_TB);
            this.Controls.Add(this.UI_ColorType_GB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_ColorType_GB.ResumeLayout(false);
            this.UI_ColorType_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_ColorType_GB;
        private System.Windows.Forms.RadioButton UI_Blue_RB;
        private System.Windows.Forms.RadioButton UI_Red_RB;
        private System.Windows.Forms.TextBox UI_Color_TB;
    }
}

