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
            label1 = new Label();
            label2 = new Label();
            hostNameValue = new Label();
            IPValue = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Host Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "IP Address:";
            // 
            // hostNameValue
            // 
            hostNameValue.AutoSize = true;
            hostNameValue.Location = new Point(88, 9);
            hostNameValue.Name = "hostNameValue";
            hostNameValue.Size = new Size(38, 15);
            hostNameValue.TabIndex = 2;
            hostNameValue.Text = "label3";
            // 
            // IPValue
            // 
            IPValue.AutoSize = true;
            IPValue.Location = new Point(88, 24);
            IPValue.Name = "IPValue";
            IPValue.Size = new Size(38, 15);
            IPValue.TabIndex = 3;
            IPValue.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(61, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(196, 71);
            Controls.Add(button1);
            Controls.Add(IPValue);
            Controls.Add(hostNameValue);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label hostNameValue;
        private Label IPValue;
        private Button button1;
    }
}