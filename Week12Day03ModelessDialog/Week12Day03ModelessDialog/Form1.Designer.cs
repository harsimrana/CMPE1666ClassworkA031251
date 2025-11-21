namespace Week12Day03ModelessDialog
{
    partial class UI_MainForm
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
            this.UI_Lbl_DialogText = new System.Windows.Forms.Label();
            this.UI_ShowDialog_Cbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UI_Lbl_DialogText
            // 
            this.UI_Lbl_DialogText.AutoSize = true;
            this.UI_Lbl_DialogText.Location = new System.Drawing.Point(40, 166);
            this.UI_Lbl_DialogText.Name = "UI_Lbl_DialogText";
            this.UI_Lbl_DialogText.Size = new System.Drawing.Size(0, 13);
            this.UI_Lbl_DialogText.TabIndex = 0;
            // 
            // UI_ShowDialog_Cbx
            // 
            this.UI_ShowDialog_Cbx.AutoSize = true;
            this.UI_ShowDialog_Cbx.Location = new System.Drawing.Point(43, 45);
            this.UI_ShowDialog_Cbx.Name = "UI_ShowDialog_Cbx";
            this.UI_ShowDialog_Cbx.Size = new System.Drawing.Size(86, 17);
            this.UI_ShowDialog_Cbx.TabIndex = 1;
            this.UI_ShowDialog_Cbx.Text = "Show Dialog";
            this.UI_ShowDialog_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowDialog_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowDialog_Cbx_CheckedChanged);
            // 
            // UI_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 289);
            this.Controls.Add(this.UI_ShowDialog_Cbx);
            this.Controls.Add(this.UI_Lbl_DialogText);
            this.Name = "UI_MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Lbl_DialogText;
        private System.Windows.Forms.CheckBox UI_ShowDialog_Cbx;
    }
}

