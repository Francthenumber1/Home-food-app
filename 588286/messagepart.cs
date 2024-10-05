using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HomeFood._588286
{
    public partial class message : Form
    {
        private List<Message> messages;

        public message(List<Message> messages)
        {
            InitializeComponent();
            this.messages = messages;
        }

        private void message_Load(object sender, EventArgs e)
        {
            messageview.DataSource = new BindingList<Message>(messages);
            messageview.AutoGenerateColumns = true;
        }

        private void messageview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid cell, not on the column header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = messageview.Rows[e.RowIndex];

                // Retrieve the data from the selected row
                string authorName = row.Cells["AuthorName"].Value.ToString();
                string messageText = row.Cells["MessageText"].Value.ToString();

                // Display the data in a MessageBox
                MessageBox.Show($"Author: {authorName}\nMessage: {messageText}", "Message Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
