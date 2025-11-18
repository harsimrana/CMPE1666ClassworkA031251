namespace Week12Day01ModalDialogs
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
            this.UI_Btn_Message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Btn_Message
            // 
            this.UI_Btn_Message.Location = new System.Drawing.Point(80, 139);
            this.UI_Btn_Message.Name = "UI_Btn_Message";
            this.UI_Btn_Message.Size = new System.Drawing.Size(95, 33);
            this.UI_Btn_Message.TabIndex = 0;
            this.UI_Btn_Message.Text = "Message";
            this.UI_Btn_Message.UseVisualStyleBackColor = true;
            this.UI_Btn_Message.Click += new System.EventHandler(this.UI_Btn_Message_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Btn_Message);
            this.Name = "Form1";
            this.Text = "Modal Dialogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Btn_Message;
    }
}

