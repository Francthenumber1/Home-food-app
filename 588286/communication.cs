using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeFood._588286
{
    public partial class communication : Form
    {
        private static List<Message> messages = new List<Message>();

        public communication()
        {
            InitializeComponent();
        }

        private void Send_message_Click(object sender, EventArgs e)
        {
            string authorName = name_textbox.Text;  // Assuming textBox1 is for author name
            string messageText = messagetextbox.Text; // Assuming textBox2 is for the message

            if (string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(messageText))
            {
                MessageBox.Show("Please enter both your name and your message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the message to the list
            messages.Add(new Message(authorName, messageText));

            MessageBox.Show("Your message has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            name_textbox.Clear();  // Clear the text boxes after successful submission
            messagetextbox.Clear();
        }

        public static List<Message> GetMessages()
        {
            return messages;
        }
    }
}
