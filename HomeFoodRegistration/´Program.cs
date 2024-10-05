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

            // Öffne zuerst das Registrierungsformular
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            // Nachdem das Registrierungsformular geschlossen wurde, öffne das Anmeldeformular
            HomeFoodRegistration.Form1 loginForm = new HomeFoodRegistration.Form1(); // Hier wird explizit der Namensraum verwendet
            Application.Run(loginForm);
        }
    }
}
