namespace week3day3demo_checkbox
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
            this.UI_Item1Cost_Lbl = new System.Windows.Forms.Label();
            this.UI_Item2Cost_Lbl = new System.Windows.Forms.Label();
            this.UI_Item1Cost_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Item2Cost_Tbx = new System.Windows.Forms.TextBox();
            this.UI_GST_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_TotalCost_Btn = new System.Windows.Forms.Button();
            this.UI_TotalCost_Lbl = new System.Windows.Forms.Label();
            this.UI_TotalCost_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Item1Cost_Lbl
            // 
            this.UI_Item1Cost_Lbl.AutoSize = true;
            this.UI_Item1Cost_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Item1Cost_Lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UI_Item1Cost_Lbl.Location = new System.Drawing.Point(98, 64);
            this.UI_Item1Cost_Lbl.Name = "UI_Item1Cost_Lbl";
            this.UI_Item1Cost_Lbl.Size = new System.Drawing.Size(102, 20);
            this.UI_Item1Cost_Lbl.TabIndex = 0;
            this.UI_Item1Cost_Lbl.Text = "Item 1 Cost";
            // 
            // UI_Item2Cost_Lbl
            // 
            this.UI_Item2Cost_Lbl.AutoSize = true;
            this.UI_Item2Cost_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Item2Cost_Lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UI_Item2Cost_Lbl.Location = new System.Drawing.Point(98, 109);
            this.UI_Item2Cost_Lbl.Name = "UI_Item2Cost_Lbl";
            this.UI_Item2Cost_Lbl.Size = new System.Drawing.Size(102, 20);
            this.UI_Item2Cost_Lbl.TabIndex = 2;
            this.UI_Item2Cost_Lbl.Text = "Item 2 Cost";
            // 
            // UI_Item1Cost_Tbx
            // 
            this.UI_Item1Cost_Tbx.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UI_Item1Cost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Item1Cost_Tbx.ForeColor = System.Drawing.SystemColors.Window;
            this.UI_Item1Cost_Tbx.Location = new System.Drawing.Point(220, 64);
            this.UI_Item1Cost_Tbx.Name = "UI_Item1Cost_Tbx";
            this.UI_Item1Cost_Tbx.Size = new System.Drawing.Size(100, 26);
            this.UI_Item1Cost_Tbx.TabIndex = 1;
            this.UI_Item1Cost_Tbx.Text = "0";
            this.UI_Item1Cost_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_Item2Cost_Tbx
            // 
            this.UI_Item2Cost_Tbx.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UI_Item2Cost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Item2Cost_Tbx.ForeColor = System.Drawing.SystemColors.Window;
            this.UI_Item2Cost_Tbx.Location = new System.Drawing.Point(220, 107);
            this.UI_Item2Cost_Tbx.Name = "UI_Item2Cost_Tbx";
            this.UI_Item2Cost_Tbx.Size = new System.Drawing.Size(100, 26);
            this.UI_Item2Cost_Tbx.TabIndex = 3;
            this.UI_Item2Cost_Tbx.Text = "0";
            this.UI_Item2Cost_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_GST_Cbx
            // 
            this.UI_GST_Cbx.AutoSize = true;
            this.UI_GST_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_GST_Cbx.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.UI_GST_Cbx.Location = new System.Drawing.Point(102, 154);
            this.UI_GST_Cbx.Name = "UI_GST_Cbx";
            this.UI_GST_Cbx.Size = new System.Drawing.Size(117, 24);
            this.UI_GST_Cbx.TabIndex = 4;
            this.UI_GST_Cbx.Text = "Include GST";
            this.UI_GST_Cbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_GST_Cbx.UseVisualStyleBackColor = true;
            this.UI_GST_Cbx.CheckedChanged += new System.EventHandler(this.UI_GST_Cbx_CheckedChanged);
            // 
            // UI_TotalCost_Btn
            // 
            this.UI_TotalCost_Btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.UI_TotalCost_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalCost_Btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_TotalCost_Btn.Location = new System.Drawing.Point(102, 203);
            this.UI_TotalCost_Btn.Name = "UI_TotalCost_Btn";
            this.UI_TotalCost_Btn.Size = new System.Drawing.Size(218, 34);
            this.UI_TotalCost_Btn.TabIndex = 5;
            this.UI_TotalCost_Btn.Text = "Total Cost";
            this.UI_TotalCost_Btn.UseVisualStyleBackColor = false;
            this.UI_TotalCost_Btn.Click += new System.EventHandler(this.UI_TotalCost_Btn_Click);
            // 
            // UI_TotalCost_Lbl
            // 
            this.UI_TotalCost_Lbl.AutoSize = true;
            this.UI_TotalCost_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalCost_Lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UI_TotalCost_Lbl.Location = new System.Drawing.Point(98, 266);
            this.UI_TotalCost_Lbl.Name = "UI_TotalCost_Lbl";
            this.UI_TotalCost_Lbl.Size = new System.Drawing.Size(91, 20);
            this.UI_TotalCost_Lbl.TabIndex = 6;
            this.UI_TotalCost_Lbl.Text = "Total Cost";
            // 
            // UI_TotalCost_Tbx
            // 
            this.UI_TotalCost_Tbx.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UI_TotalCost_Tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_TotalCost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalCost_Tbx.ForeColor = System.Drawing.SystemColors.Window;
            this.UI_TotalCost_Tbx.Location = new System.Drawing.Point(220, 266);
            this.UI_TotalCost_Tbx.Name = "UI_TotalCost_Tbx";
            this.UI_TotalCost_Tbx.ReadOnly = true;
            this.UI_TotalCost_Tbx.Size = new System.Drawing.Size(100, 19);
            this.UI_TotalCost_Tbx.TabIndex = 7;
            this.UI_TotalCost_Tbx.Text = "0";
            this.UI_TotalCost_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(428, 311);
            this.Controls.Add(this.UI_TotalCost_Tbx);
            this.Controls.Add(this.UI_TotalCost_Lbl);
            this.Controls.Add(this.UI_TotalCost_Btn);
            this.Controls.Add(this.UI_GST_Cbx);
            this.Controls.Add(this.UI_Item2Cost_Tbx);
            this.Controls.Add(this.UI_Item1Cost_Tbx);
            this.Controls.Add(this.UI_Item2Cost_Lbl);
            this.Controls.Add(this.UI_Item1Cost_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Item1Cost_Lbl;
        private System.Windows.Forms.Label UI_Item2Cost_Lbl;
        private System.Windows.Forms.TextBox UI_Item1Cost_Tbx;
        private System.Windows.Forms.TextBox UI_Item2Cost_Tbx;
        private System.Windows.Forms.CheckBox UI_GST_Cbx;
        private System.Windows.Forms.Button UI_TotalCost_Btn;
        private System.Windows.Forms.Label UI_TotalCost_Lbl;
        private System.Windows.Forms.TextBox UI_TotalCost_Tbx;
    }
}

