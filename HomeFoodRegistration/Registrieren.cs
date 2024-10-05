using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HomeFoodRegistration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string username = textBoxUsername.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            // Validierung der Eingaben
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
                return;
            }

            // Validierung Benutzername
            if (!IsValidUsername(username))
            {
                MessageBox.Show("Ungültiger Benutzername. Benutzername darf keine Sonderzeichen enthalten.");
                return;
            }


            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Ungültige Telefonnummer. Telefonnummer darf nur Ziffern enthalten.");
                return;
            }


            if (password != confirmPassword)
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein.");
                return;
            }

            // Datenbankoperation: Speichern der Registrierung
            string connectionString = "Data Source=registration.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Registrations (Name, Username, Phone, Email, Password) " +
                               "VALUES (@Name, @Username, @Phone, @Email, @Password)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registrierung erfolgreich!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}");
                    }
                }
            }
        }

        private bool IsValidUsername(string username)
        {
            // Überprüfung auf Sonderzeichen im Benutzernamen
            return !Regex.IsMatch(username, @"[!@#$%^&*(),.?\"":{}|<>]");
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // Überprüfung, ob die Telefonnummer nur aus Ziffern besteht
            return Regex.IsMatch(phone, @"^\d+$");
        }

        private bool IsValidEmail(string email, string confirmEmail)
        {
            // Überprüfung der E-Mail-Adresse und ob sie mit der bestätigten E-Mail-Adresse übereinstimmt
            if (email != confirmEmail)
                return false;

            // Überprüfung auf gültige E-Mail-Adresse (enthält @)
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void labelConfirmEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
