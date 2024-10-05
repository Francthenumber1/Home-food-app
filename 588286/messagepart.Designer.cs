namespace HomeFood._588286
{
    partial class message
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView messageview;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.messageview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.messageview)).BeginInit();
            this.SuspendLayout();
            // 
            // messageview
            // 
            this.messageview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageview.Location = new System.Drawing.Point(0, 0);
            this.messageview.Name = "messageview";
            this.messageview.Size = new System.Drawing.Size(800, 450);
            this.messageview.TabIndex = 0;
            this.messageview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messageview_CellClick);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageview);
            this.Name = "message";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageview)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
