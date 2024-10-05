using System;
using System.Windows.Forms;

namespace HomeFoodRegistration
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialisiere die Datenbank
            SQLiteDatabase database = new SQLiteDatabase("homefood.db");
            database.InitializeDatabase();

            // Öffne zuerst das Registrierungsformular
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            // Nachdem das Registrierungsformular geschlossen wurde, öffne das Anmeldeformular
            if (registrationForm.DialogResult == DialogResult.OK || registrationForm.DialogResult == DialogResult.Cancel)
            {
                Application.Run(new Form1());
            }
        }
    }
}
