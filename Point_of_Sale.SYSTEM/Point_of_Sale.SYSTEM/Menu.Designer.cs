﻿namespace Point_of_Sale.SYSTEM
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
            this.LogDisplay.Location = new System.Drawing.Point(0, 0);
            this.LogDisplay.Name = "LogDisplay";
            this.LogDisplay.Size = new System.Drawing.Size(468, 210);
            this.LogDisplay.TabIndex = 0;
            this.LogDisplay.Text = "";
            this.LogDisplay.TextChanged += new System.EventHandler(this.LogDisplay_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1193, 695);
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
    }
}