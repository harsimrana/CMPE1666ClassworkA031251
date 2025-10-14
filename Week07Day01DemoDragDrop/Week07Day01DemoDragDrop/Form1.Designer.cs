namespace Week07Day01DemoDragDrop
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
            this.UI_Lbl_DragDrop = new System.Windows.Forms.Label();
            this.UI_Lbx_FileData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_Lbl_DragDrop
            // 
            this.UI_Lbl_DragDrop.AllowDrop = true;
            this.UI_Lbl_DragDrop.AutoSize = true;
            this.UI_Lbl_DragDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Lbl_DragDrop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UI_Lbl_DragDrop.Location = new System.Drawing.Point(41, 26);
            this.UI_Lbl_DragDrop.Name = "UI_Lbl_DragDrop";
            this.UI_Lbl_DragDrop.Size = new System.Drawing.Size(189, 25);
            this.UI_Lbl_DragDrop.TabIndex = 0;
            this.UI_Lbl_DragDrop.Text = "Drop your file here";
            this.UI_Lbl_DragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_Lbl_DragDrop_DragDrop);
            this.UI_Lbl_DragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_Lbl_DragDrop_DragEnter);
            // 
            // UI_Lbx_FileData
            // 
            this.UI_Lbx_FileData.FormattingEnabled = true;
            this.UI_Lbx_FileData.Location = new System.Drawing.Point(46, 77);
            this.UI_Lbx_FileData.Name = "UI_Lbx_FileData";
            this.UI_Lbx_FileData.Size = new System.Drawing.Size(184, 290);
            this.UI_Lbx_FileData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Lbx_FileData);
            this.Controls.Add(this.UI_Lbl_DragDrop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Lbl_DragDrop;
        private System.Windows.Forms.ListBox UI_Lbx_FileData;
    }
}

