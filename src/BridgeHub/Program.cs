using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BridgeHub.Core;

namespace BridgeHub
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BridgeApi.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
