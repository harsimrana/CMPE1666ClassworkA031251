namespace Week12Day03ModelessDialog
{
    partial class ModelessDialog
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
            this.UI_Tbx_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Tbx_input
            // 
            this.UI_Tbx_input.Location = new System.Drawing.Point(29, 38);
            this.UI_Tbx_input.Name = "UI_Tbx_input";
            this.UI_Tbx_input.Size = new System.Drawing.Size(447, 20);
            this.UI_Tbx_input.TabIndex = 0;
            this.UI_Tbx_input.TextChanged += new System.EventHandler(this.UI_Tbx_input_TextChanged);
            // 
            // ModelessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 111);
            this.Controls.Add(this.UI_Tbx_input);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelessDialog";
            this.Text = "ModelessDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Tbx_input;
    }
}