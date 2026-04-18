
using System;
using System.Windows.Forms;

namespace ProductivityTracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Standard startup code for Windows Forms apps
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open the MDI parent form
            Application.Run(new MDIProductivityDashboard());
        }
    }
}
