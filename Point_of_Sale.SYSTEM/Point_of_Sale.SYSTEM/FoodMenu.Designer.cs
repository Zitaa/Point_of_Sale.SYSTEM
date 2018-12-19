namespace Point_of_Sale.SYSTEM
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            this.doubleBufferedPanel1 = new DoubleBufferedPanel();
            this.CostDisplay = new Point_of_Sale.SYSTEM.TransparentRichTextBox();
            this.OrdersLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleBufferedPanel3 = new DoubleBufferedPanel();
            this.DishOrdersDisplay = new Point_of_Sale.SYSTEM.TransparentRichTextBox();
            this.FoodLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.doubleBufferedPanel1.SuspendLayout();
            this.doubleBufferedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedPanel1.AutoSize = true;
            this.doubleBufferedPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doubleBufferedPanel1.BackgroundImage")));
            this.doubleBufferedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doubleBufferedPanel1.Controls.Add(this.CostDisplay);
            this.doubleBufferedPanel1.Controls.Add(this.OrdersLayoutPanel);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel3);
            this.doubleBufferedPanel1.Controls.Add(this.FoodLayoutPanel);
            this.doubleBufferedPanel1.Controls.Add(this.TerminateButton);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferedPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(1500, 823);
            this.doubleBufferedPanel1.TabIndex = 0;
            // 
            // CostDisplay
            // 
            this.CostDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CostDisplay.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostDisplay.Location = new System.Drawing.Point(494, 755);
            this.CostDisplay.Name = "CostDisplay";
            this.CostDisplay.Size = new System.Drawing.Size(233, 68);
            this.CostDisplay.TabIndex = 0;
            this.CostDisplay.Text = "";
            // 
            // OrdersLayoutPanel
            // 
            this.OrdersLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrdersLayoutPanel.Location = new System.Drawing.Point(503, 15);
            this.OrdersLayoutPanel.Name = "OrdersLayoutPanel";
            this.OrdersLayoutPanel.Size = new System.Drawing.Size(238, 440);
            this.OrdersLayoutPanel.TabIndex = 0;
            // 
            // doubleBufferedPanel3
            // 
            this.doubleBufferedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.doubleBufferedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.doubleBufferedPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleBufferedPanel3.Controls.Add(this.DishOrdersDisplay);
            this.doubleBufferedPanel3.Location = new System.Drawing.Point(16, 15);
            this.doubleBufferedPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            this.doubleBufferedPanel3.Size = new System.Drawing.Size(471, 793);
            this.doubleBufferedPanel3.TabIndex = 3;
            // 
            // DishOrdersDisplay
            // 
            this.DishOrdersDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DishOrdersDisplay.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DishOrdersDisplay.Location = new System.Drawing.Point(0, 0);
            this.DishOrdersDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.DishOrdersDisplay.Name = "DishOrdersDisplay";
            this.DishOrdersDisplay.Size = new System.Drawing.Size(470, 793);
            this.DishOrdersDisplay.TabIndex = 0;
            this.DishOrdersDisplay.Text = "";
            // 
            // FoodLayoutPanel
            // 
            this.FoodLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FoodLayoutPanel.Location = new System.Drawing.Point(821, 63);
            this.FoodLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FoodLayoutPanel.Name = "FoodLayoutPanel";
            this.FoodLayoutPanel.Size = new System.Drawing.Size(657, 745);
            this.FoodLayoutPanel.TabIndex = 1;
            // 
            // TerminateButton
            // 
            this.TerminateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TerminateButton.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateButton.Location = new System.Drawing.Point(1435, 0);
            this.TerminateButton.Margin = new System.Windows.Forms.Padding(4);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(61, 55);
            this.TerminateButton.TabIndex = 0;
            this.TerminateButton.Text = "X";
            this.TerminateButton.UseVisualStyleBackColor = true;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click_1);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 822);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.doubleBufferedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.FlowLayoutPanel FoodLayoutPanel;
        private DoubleBufferedPanel doubleBufferedPanel3;
        private TransparentRichTextBox DishOrdersDisplay;
        private System.Windows.Forms.FlowLayoutPanel OrdersLayoutPanel;
        private TransparentRichTextBox CostDisplay;
    }
}