
using System;
using System.Windows.Forms;
using BridgeHub.Controls;
using BridgeHub.Core;
using BridgeHub.Forms;
using MetroFramework.Forms;

namespace BridgeHub
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            var lights = BridgeApi.GetLights();
            int devices = lights.Count;
            int rows = (int)Math.Ceiling((devices / 2f));

            for (int row = 0; row < lights.Count; row++)
            {
                this.DashbordLayout.RowCount += 1;

                this.DashbordLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0f));
                this.DashbordLayout.Controls.Add(new LightDashboardControl(lights[row].Id)
                {
                    Anchor = (AnchorStyles.Left | AnchorStyles.Right)

                }, 0, this.DashbordLayout.RowCount - 1);
            }

            Console.WriteLine(Helper.ConvertRgbToXy(177, 40, 40));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TrayIcon.Dispose();
            Application.Exit();
        }

        // Menu Items
        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void ShowForm()
        {
            this.Show();
            this.BringToFront();
            this.FocusMe();
            this.WindowState = FormWindowState.Normal;
        }

    }
}
