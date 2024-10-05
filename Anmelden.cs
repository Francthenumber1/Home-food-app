using System;
using System.Windows.Forms;
using System.Data.SQLite;

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
                MessageBox.Show("Login erfolgreich!");
                // Weiter zur nächsten Hauptanwendungsfenster
            }
            else
            {
                MessageBox.Show("Ungültiger Benutzername oder Passwort. Bitte versuchen Sie es erneut.");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string connectionString = "Data Source=homefood.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Registrations WHERE Username = @Username AND Password = @Password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Logik für Passwort vergessen
        }

        private void pictureBoxUserLogo_Click(object sender, EventArgs e)
        {
            // Logik für Benutzerlogo-Klick
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Logik für Formular-Load
        }
    }
}
