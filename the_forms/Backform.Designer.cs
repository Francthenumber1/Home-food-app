﻿namespace HomeFood
{
    partial class BackForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblHomeFood = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.pictureBoxRecipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(468, 134);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(990, 593);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblHomeFood
            // 
            this.lblHomeFood.Font = new System.Drawing.Font("Segoe UI Historic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeFood.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHomeFood.Location = new System.Drawing.Point(448, 9);
            this.lblHomeFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeFood.Name = "lblHomeFood";
            this.lblHomeFood.Size = new System.Drawing.Size(447, 80);
            this.lblHomeFood.TabIndex = 8;
            this.lblHomeFood.Text = "Home Food";
            this.lblHomeFood.Click += new System.EventHandler(this.lblHomeFood_Click);
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(161, 109);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(165, 29);
            this.lblRecipeName.TabIndex = 17;
            this.lblRecipeName.Text = "RecipeName";
            this.lblRecipeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxRecipe
            // 
            this.pictureBoxRecipe.Location = new System.Drawing.Point(-4, 192);
            this.pictureBoxRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxRecipe.Name = "pictureBoxRecipe";
            this.pictureBoxRecipe.Size = new System.Drawing.Size(465, 513);
            this.pictureBoxRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecipe.TabIndex = 18;
            this.pictureBoxRecipe.TabStop = false;
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1470, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxRecipe);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.lblHomeFood);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackForm";
            this.Load += new System.EventHandler(this.BackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblHomeFood;
        public System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.PictureBox pictureBoxRecipe;
    }
}