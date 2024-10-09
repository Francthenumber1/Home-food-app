using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFood
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // steuerelemente nicht veraltet
            Application.SetCompatibleTextRenderingDefault(false);  // gut performance 
            Application.Run(new loginReal());  //Run
        }
    }
}
