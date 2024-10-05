using System;
using System.Windows.Forms;

namespace HomeFoodRegistration

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Überprüfung der Anmeldedaten
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Weiter zur nächsten Hauptanwendungsfenster
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Implementiere Login-Validierungslogik
            // Einfache Überprüfung
            return username == "homefood" && password == "password";
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBoxUserLogo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
