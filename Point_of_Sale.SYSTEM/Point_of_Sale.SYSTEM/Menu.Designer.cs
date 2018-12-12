namespace Point_of_Sale.SYSTEM
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogDisplay = new System.Windows.Forms.RichTextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogDisplay);
            this.panel1.Location = new System.Drawing.Point(12, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 210);
            this.panel1.TabIndex = 0;
            // 
            // LogDisplay
            // 
            this.LogDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogDisplay.Location = new System.Drawing.Point(0, 0);
            this.LogDisplay.Name = "LogDisplay";
            this.LogDisplay.ReadOnly = true;
            this.LogDisplay.Size = new System.Drawing.Size(468, 210);
            this.LogDisplay.TabIndex = 0;
            this.LogDisplay.Text = "";
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.Color.Silver;
            this.TestButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.Location = new System.Drawing.Point(899, 60);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(239, 153);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "Hamburger";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TerminateButton
            // 
            this.TerminateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateButton.Location = new System.Drawing.Point(-3, -5);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(51, 53);
            this.TerminateButton.TabIndex = 2;
            this.TerminateButton.Text = "X";
            this.TerminateButton.UseVisualStyleBackColor = true;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1193, 695);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox LogDisplay;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button TerminateButton;
    }
}