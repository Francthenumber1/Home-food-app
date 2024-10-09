namespace HomeFood._588286
{
    partial class communication
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.messagetextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Send_message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(149, 12);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(332, 22);
            this.name_textbox.TabIndex = 0;
            // 
            // messagetextbox
            // 
            this.messagetextbox.Location = new System.Drawing.Point(149, 53);
            this.messagetextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messagetextbox.Multiline = true;
            this.messagetextbox.Name = "messagetextbox";
            this.messagetextbox.Size = new System.Drawing.Size(332, 208);
            this.messagetextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "AuthorName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kommentar";
            // 
            // Send_message
            // 
            this.Send_message.Location = new System.Drawing.Point(232, 284);
            this.Send_message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send_message.Name = "Send_message";
            this.Send_message.Size = new System.Drawing.Size(168, 28);
            this.Send_message.TabIndex = 4;
            this.Send_message.Text = " Comment sending";
            this.Send_message.UseVisualStyleBackColor = true;
            this.Send_message.Click += new System.EventHandler(this.Send_message_Click);
            // 
            // communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 342);
            this.Controls.Add(this.Send_message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagetextbox);
            this.Controls.Add(this.name_textbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox messagetextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send_message;
    }
}