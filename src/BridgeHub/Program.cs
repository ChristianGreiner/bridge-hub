using BridgeHub.Core;
using BridgeHub.Forms;
using System;
using System.Windows.Forms;

namespace BridgeHub
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Settings.Instance.Load();
            BridgeApi.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}