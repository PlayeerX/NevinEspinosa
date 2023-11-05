using AssignmentPC102AdjacencyIncident;
using System;
using System.Windows.Forms;

namespace YourProjectNamespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InputForm()); // 'Form1' is the startup form class in this case
        }
    }
}
