namespace Host_and_IP_Window
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hostNameValue = new System.Windows.Forms.Label();
            this.IPValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // hostNameValue
            // 
            this.hostNameValue.AutoSize = true;
            this.hostNameValue.Location = new System.Drawing.Point(88, 9);
            this.hostNameValue.Name = "hostNameValue";
            this.hostNameValue.Size = new System.Drawing.Size(38, 15);
            this.hostNameValue.TabIndex = 2;
            this.hostNameValue.Text = "label3";
            // 
            // IPValue
            // 
            this.IPValue.AutoSize = true;
            this.IPValue.Location = new System.Drawing.Point(88, 24);
            this.IPValue.Name = "IPValue";
            this.IPValue.Size = new System.Drawing.Size(38, 15);
            this.IPValue.TabIndex = 3;
            this.IPValue.Text = "label4";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(196, 54);
            this.Controls.Add(this.IPValue);
            this.Controls.Add(this.hostNameValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label hostNameValue;
        private Label IPValue;
    }
}