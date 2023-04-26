using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            User u1 = new User("User1");
            User u2 = new User("User2");
            MainMenuForm m1 = new MainMenuForm(u1);
            MainMenuForm m2 = new MainMenuForm(u2);
            m2.Show();
            Application.Run(m1);
        }
    }
}


