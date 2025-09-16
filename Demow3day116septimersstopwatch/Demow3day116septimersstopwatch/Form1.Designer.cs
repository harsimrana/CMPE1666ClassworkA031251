namespace Demow3day116septimersstopwatch
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
            this.components = new System.ComponentModel.Container();
            this.UI_timer1 = new System.Windows.Forms.Timer(this.components);
            this.UI_Screen_Lb = new System.Windows.Forms.Label();
            this.UI_Time_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Stop_Btn = new System.Windows.Forms.Button();
            this.UI_List_Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_timer1
            // 
            this.UI_timer1.Interval = 1000;
            this.UI_timer1.Tick += new System.EventHandler(this.UI_timer1_Tick);
            // 
            // UI_Screen_Lb
            // 
            this.UI_Screen_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Screen_Lb.Location = new System.Drawing.Point(21, 18);
            this.UI_Screen_Lb.Name = "UI_Screen_Lb";
            this.UI_Screen_Lb.Size = new System.Drawing.Size(730, 48);
            this.UI_Screen_Lb.TabIndex = 0;
            this.UI_Screen_Lb.Text = "0";
            // 
            // UI_Time_Tbx
            // 
            this.UI_Time_Tbx.Location = new System.Drawing.Point(231, 18);
            this.UI_Time_Tbx.Multiline = true;
            this.UI_Time_Tbx.Name = "UI_Time_Tbx";
            this.UI_Time_Tbx.ReadOnly = true;
            this.UI_Time_Tbx.Size = new System.Drawing.Size(309, 48);
            this.UI_Time_Tbx.TabIndex = 1;
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Location = new System.Drawing.Point(231, 135);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(194, 48);
            this.UI_Stop_Btn.TabIndex = 2;
            this.UI_Stop_Btn.Text = "Stop Time";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            this.UI_Stop_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UI_List_Lbx
            // 
            this.UI_List_Lbx.FormattingEnabled = true;
            this.UI_List_Lbx.Location = new System.Drawing.Point(25, 135);
            this.UI_List_Lbx.Name = "UI_List_Lbx";
            this.UI_List_Lbx.Size = new System.Drawing.Size(168, 186);
            this.UI_List_Lbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_List_Lbx);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Controls.Add(this.UI_Time_Tbx);
            this.Controls.Add(this.UI_Screen_Lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UI_timer1;
        private System.Windows.Forms.Label UI_Screen_Lb;
        private System.Windows.Forms.TextBox UI_Time_Tbx;
        private System.Windows.Forms.Button UI_Stop_Btn;
        private System.Windows.Forms.ListBox UI_List_Lbx;
    }
}

