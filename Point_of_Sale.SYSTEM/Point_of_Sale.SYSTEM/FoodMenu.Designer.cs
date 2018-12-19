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
            this.ChangeIngredientsButton = new System.Windows.Forms.Button();
            this.doubleBufferedPanel3 = new DoubleBufferedPanel();
            this.DishOrdersDisplay = new Point_of_Sale.SYSTEM.TransparentRichTextBox();
            this.doubleBufferedPanel2 = new DoubleBufferedPanel();
            this.IngredientDisplay = new Point_of_Sale.SYSTEM.TransparentRichTextBox();
            this.FoodLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.doubleBufferedPanel1.SuspendLayout();
            this.doubleBufferedPanel3.SuspendLayout();
            this.doubleBufferedPanel2.SuspendLayout();
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
            this.doubleBufferedPanel1.Controls.Add(this.ChangeIngredientsButton);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel3);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel2);
            this.doubleBufferedPanel1.Controls.Add(this.FoodLayoutPanel);
            this.doubleBufferedPanel1.Controls.Add(this.TerminateButton);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(1125, 669);
            this.doubleBufferedPanel1.TabIndex = 0;
            // 
            // ChangeIngredientsButton
            // 
            this.ChangeIngredientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeIngredientsButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeIngredientsButton.Location = new System.Drawing.Point(338, 622);
            this.ChangeIngredientsButton.Name = "ChangeIngredientsButton";
            this.ChangeIngredientsButton.Size = new System.Drawing.Size(128, 34);
            this.ChangeIngredientsButton.TabIndex = 1;
            this.ChangeIngredientsButton.Text = "Change Ingredients";
            this.ChangeIngredientsButton.UseVisualStyleBackColor = true;
            this.ChangeIngredientsButton.Click += new System.EventHandler(this.ChangeIngredientsButton_Click);
            // 
            // doubleBufferedPanel3
            // 
            this.doubleBufferedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.doubleBufferedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.doubleBufferedPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleBufferedPanel3.Controls.Add(this.DishOrdersDisplay);
            this.doubleBufferedPanel3.Location = new System.Drawing.Point(12, 12);
            this.doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            this.doubleBufferedPanel3.Size = new System.Drawing.Size(320, 359);
            this.doubleBufferedPanel3.TabIndex = 3;
            // 
            // DishOrdersDisplay
            // 
            this.DishOrdersDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DishOrdersDisplay.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DishOrdersDisplay.Location = new System.Drawing.Point(0, 0);
            this.DishOrdersDisplay.Name = "DishOrdersDisplay";
            this.DishOrdersDisplay.Size = new System.Drawing.Size(320, 359);
            this.DishOrdersDisplay.TabIndex = 0;
            this.DishOrdersDisplay.Text = "";
            // 
            // doubleBufferedPanel2
            // 
            this.doubleBufferedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doubleBufferedPanel2.AutoSize = true;
            this.doubleBufferedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.doubleBufferedPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleBufferedPanel2.Controls.Add(this.IngredientDisplay);
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(12, 387);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(319, 269);
            this.doubleBufferedPanel2.TabIndex = 0;
            // 
            // IngredientDisplay
            // 
            this.IngredientDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IngredientDisplay.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientDisplay.ForeColor = System.Drawing.Color.Black;
            this.IngredientDisplay.Location = new System.Drawing.Point(-1, -1);
            this.IngredientDisplay.Name = "IngredientDisplay";
            this.IngredientDisplay.Size = new System.Drawing.Size(320, 269);
            this.IngredientDisplay.TabIndex = 2;
            this.IngredientDisplay.Text = "";
            // 
            // FoodLayoutPanel
            // 
            this.FoodLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FoodLayoutPanel.Location = new System.Drawing.Point(589, 51);
            this.FoodLayoutPanel.Name = "FoodLayoutPanel";
            this.FoodLayoutPanel.Size = new System.Drawing.Size(520, 605);
            this.FoodLayoutPanel.TabIndex = 1;
            // 
            // TerminateButton
            // 
            this.TerminateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TerminateButton.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateButton.Location = new System.Drawing.Point(1076, 0);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(46, 45);
            this.TerminateButton.TabIndex = 0;
            this.TerminateButton.Text = "X";
            this.TerminateButton.UseVisualStyleBackColor = true;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click_1);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 668);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.doubleBufferedPanel1.PerformLayout();
            this.doubleBufferedPanel3.ResumeLayout(false);
            this.doubleBufferedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.FlowLayoutPanel FoodLayoutPanel;
        private DoubleBufferedPanel doubleBufferedPanel2;
        private TransparentRichTextBox IngredientDisplay;
        private DoubleBufferedPanel doubleBufferedPanel3;
        private TransparentRichTextBox DishOrdersDisplay;
        private System.Windows.Forms.Button ChangeIngredientsButton;
    }
}