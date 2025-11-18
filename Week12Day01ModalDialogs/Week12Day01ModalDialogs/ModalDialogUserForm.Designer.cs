namespace Week12Day01ModalDialogs
{
    partial class ModalDialogUserForm
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
            this.UI_Btn_OK = new System.Windows.Forms.Button();
            this.UI_Btn_Cancel = new System.Windows.Forms.Button();
            this.UI_Tbx_InputUsername = new System.Windows.Forms.TextBox();
            this.UI_Lbl_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Btn_OK
            // 
            this.UI_Btn_OK.Location = new System.Drawing.Point(70, 110);
            this.UI_Btn_OK.Name = "UI_Btn_OK";
            this.UI_Btn_OK.Size = new System.Drawing.Size(154, 47);
            this.UI_Btn_OK.TabIndex = 0;
            this.UI_Btn_OK.Text = "OK";
            this.UI_Btn_OK.UseVisualStyleBackColor = true;
            this.UI_Btn_OK.Click += new System.EventHandler(this.UI_Btn_OK_Click);
            // 
            // UI_Btn_Cancel
            // 
            this.UI_Btn_Cancel.Location = new System.Drawing.Point(288, 110);
            this.UI_Btn_Cancel.Name = "UI_Btn_Cancel";
            this.UI_Btn_Cancel.Size = new System.Drawing.Size(154, 47);
            this.UI_Btn_Cancel.TabIndex = 1;
            this.UI_Btn_Cancel.Text = "Cancel";
            this.UI_Btn_Cancel.UseVisualStyleBackColor = true;
            this.UI_Btn_Cancel.Click += new System.EventHandler(this.UI_Btn_Cancel_Click);
            // 
            // UI_Tbx_InputUsername
            // 
            this.UI_Tbx_InputUsername.Location = new System.Drawing.Point(145, 41);
            this.UI_Tbx_InputUsername.Name = "UI_Tbx_InputUsername";
            this.UI_Tbx_InputUsername.Size = new System.Drawing.Size(297, 20);
            this.UI_Tbx_InputUsername.TabIndex = 2;
            // 
            // UI_Lbl_Username
            // 
            this.UI_Lbl_Username.AutoSize = true;
            this.UI_Lbl_Username.Location = new System.Drawing.Point(67, 44);
            this.UI_Lbl_Username.Name = "UI_Lbl_Username";
            this.UI_Lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.UI_Lbl_Username.TabIndex = 3;
            this.UI_Lbl_Username.Text = "Username";
            // 
            // ModalDialogUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 178);
            this.Controls.Add(this.UI_Lbl_Username);
            this.Controls.Add(this.UI_Tbx_InputUsername);
            this.Controls.Add(this.UI_Btn_Cancel);
            this.Controls.Add(this.UI_Btn_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialogUserForm";
            this.Text = "ModalDialogUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Btn_OK;
        private System.Windows.Forms.Button UI_Btn_Cancel;
        private System.Windows.Forms.TextBox UI_Tbx_InputUsername;
        private System.Windows.Forms.Label UI_Lbl_Username;
    }
}