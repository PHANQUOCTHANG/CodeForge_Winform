using System;
using System.Windows.Forms;
using CodeForge_Winform.CodeForge_Winform.Presentation.Forms;
using CodeForge_Winform.CodeForge_Winform.Presentation.Forms.Student;
using CodeForge_Winform.CodeForge_Winform.Presentation.Forms.Admin;

namespace CodeForge_Winform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormAdmin());
        }
    }
}
