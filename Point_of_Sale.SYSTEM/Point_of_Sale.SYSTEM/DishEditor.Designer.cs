﻿namespace Point_of_Sale.SYSTEM
{
    partial class DishEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishEditor));
            this.doubleBufferedPanel1 = new DoubleBufferedPanel();
            this.RemoveIngredient = new System.Windows.Forms.Button();
            this.AddIngredient = new System.Windows.Forms.Button();
            this.doubleBufferedPanel2 = new DoubleBufferedPanel();
            this.IngredientDisplay = new Point_of_Sale.SYSTEM.TransparentRichTextBox();
            this.IngredientFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FinishDish = new System.Windows.Forms.Button();
            this.doubleBufferedPanel1.SuspendLayout();
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
            this.doubleBufferedPanel1.Controls.Add(this.FinishDish);
            this.doubleBufferedPanel1.Controls.Add(this.RemoveIngredient);
            this.doubleBufferedPanel1.Controls.Add(this.AddIngredient);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel2);
            this.doubleBufferedPanel1.Controls.Add(this.IngredientFlowPanel);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(1120, 619);
            this.doubleBufferedPanel1.TabIndex = 0;
            // 
            // RemoveIngredient
            // 
            this.RemoveIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveIngredient.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveIngredient.Location = new System.Drawing.Point(288, 545);
            this.RemoveIngredient.Name = "RemoveIngredient";
            this.RemoveIngredient.Size = new System.Drawing.Size(210, 60);
            this.RemoveIngredient.TabIndex = 2;
            this.RemoveIngredient.Text = "Remove";
            this.RemoveIngredient.UseVisualStyleBackColor = true;
            this.RemoveIngredient.Click += new System.EventHandler(this.RemoveIngredient_Click);
            // 
            // AddIngredient
            // 
            this.AddIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddIngredient.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredient.Location = new System.Drawing.Point(12, 545);
            this.AddIngredient.Name = "AddIngredient";
            this.AddIngredient.Size = new System.Drawing.Size(210, 60);
            this.AddIngredient.TabIndex = 0;
            this.AddIngredient.Text = "Add";
            this.AddIngredient.UseVisualStyleBackColor = true;
            this.AddIngredient.Click += new System.EventHandler(this.AddIngredient_Click);
            // 
            // doubleBufferedPanel2
            // 
            this.doubleBufferedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedPanel2.AutoSize = true;
            this.doubleBufferedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.doubleBufferedPanel2.Controls.Add(this.IngredientDisplay);
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(772, 12);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(335, 593);
            this.doubleBufferedPanel2.TabIndex = 0;
            // 
            // IngredientDisplay
            // 
            this.IngredientDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IngredientDisplay.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientDisplay.Location = new System.Drawing.Point(0, 0);
            this.IngredientDisplay.Name = "IngredientDisplay";
            this.IngredientDisplay.Size = new System.Drawing.Size(332, 590);
            this.IngredientDisplay.TabIndex = 0;
            this.IngredientDisplay.Text = "";
            // 
            // IngredientFlowPanel
            // 
            this.IngredientFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IngredientFlowPanel.AutoSize = true;
            this.IngredientFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.IngredientFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.IngredientFlowPanel.Location = new System.Drawing.Point(12, 12);
            this.IngredientFlowPanel.Name = "IngredientFlowPanel";
            this.IngredientFlowPanel.Size = new System.Drawing.Size(757, 525);
            this.IngredientFlowPanel.TabIndex = 1;
            // 
            // FinishDish
            // 
            this.FinishDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FinishDish.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishDish.Location = new System.Drawing.Point(556, 545);
            this.FinishDish.Name = "FinishDish";
            this.FinishDish.Size = new System.Drawing.Size(210, 60);
            this.FinishDish.TabIndex = 3;
            this.FinishDish.Text = "Finalize...";
            this.FinishDish.UseVisualStyleBackColor = true;
            this.FinishDish.Click += new System.EventHandler(this.FinishDish_Click);
            // 
            // DishEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 614);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.Name = "DishEditor";
            this.Text = "DishEditor";
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.doubleBufferedPanel1.PerformLayout();
            this.doubleBufferedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.FlowLayoutPanel IngredientFlowPanel;
        private DoubleBufferedPanel doubleBufferedPanel2;
        private TransparentRichTextBox IngredientDisplay;
        private System.Windows.Forms.Button RemoveIngredient;
        private System.Windows.Forms.Button AddIngredient;
        private System.Windows.Forms.Button FinishDish;
    }
}