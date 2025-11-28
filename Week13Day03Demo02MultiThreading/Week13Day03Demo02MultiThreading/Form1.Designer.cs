namespace Week13Day03Demo02MultiThreading
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
            this.UI_btn_CountClick = new System.Windows.Forms.Button();
            this.UI_btn_Calculate = new System.Windows.Forms.Button();
            this.UI_lbx_SinValues = new System.Windows.Forms.ListBox();
            this.UI_lbl_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_btn_CountClick
            // 
            this.UI_btn_CountClick.Location = new System.Drawing.Point(412, 82);
            this.UI_btn_CountClick.Name = "UI_btn_CountClick";
            this.UI_btn_CountClick.Size = new System.Drawing.Size(127, 48);
            this.UI_btn_CountClick.TabIndex = 0;
            this.UI_btn_CountClick.Text = "Count Click";
            this.UI_btn_CountClick.UseVisualStyleBackColor = true;
            this.UI_btn_CountClick.Click += new System.EventHandler(this.UI_btn_CountClick_Click);
            // 
            // UI_btn_Calculate
            // 
            this.UI_btn_Calculate.Location = new System.Drawing.Point(412, 274);
            this.UI_btn_Calculate.Name = "UI_btn_Calculate";
            this.UI_btn_Calculate.Size = new System.Drawing.Size(127, 46);
            this.UI_btn_Calculate.TabIndex = 1;
            this.UI_btn_Calculate.Text = "Perform Calculation";
            this.UI_btn_Calculate.UseVisualStyleBackColor = true;
            this.UI_btn_Calculate.Click += new System.EventHandler(this.UI_btn_Calculate_Click);
            // 
            // UI_lbx_SinValues
            // 
            this.UI_lbx_SinValues.FormattingEnabled = true;
            this.UI_lbx_SinValues.Location = new System.Drawing.Point(43, 82);
            this.UI_lbx_SinValues.Name = "UI_lbx_SinValues";
            this.UI_lbx_SinValues.ScrollAlwaysVisible = true;
            this.UI_lbx_SinValues.Size = new System.Drawing.Size(321, 238);
            this.UI_lbx_SinValues.TabIndex = 2;
            // 
            // UI_lbl_Count
            // 
            this.UI_lbl_Count.AutoSize = true;
            this.UI_lbl_Count.Location = new System.Drawing.Point(40, 29);
            this.UI_lbl_Count.Name = "UI_lbl_Count";
            this.UI_lbl_Count.Size = new System.Drawing.Size(0, 13);
            this.UI_lbl_Count.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 374);
            this.Controls.Add(this.UI_lbl_Count);
            this.Controls.Add(this.UI_lbx_SinValues);
            this.Controls.Add(this.UI_btn_Calculate);
            this.Controls.Add(this.UI_btn_CountClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_btn_CountClick;
        private System.Windows.Forms.Button UI_btn_Calculate;
        private System.Windows.Forms.ListBox UI_lbx_SinValues;
        private System.Windows.Forms.Label UI_lbl_Count;
    }
}

