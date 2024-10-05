using System;
using System.Windows.Forms;

namespace HomeFood
{
    public partial class LoginForm : Form
    {
        // Hardcoded credentials for simplicity
        private const string AdminUsername = "admin";
        private const string AdminPassword = "password";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == AdminUsername && password == AdminPassword)
            {
                // Credentials are correct, open AdminRezeptEditor
                AdminRezeptEditor adminRezeptEditor = new AdminRezeptEditor();
                adminRezeptEditor.Show();
                this.Hide(); // Optionally hide the login form
            }
            else
            {
                // Credentials are incorrect, show error message
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
