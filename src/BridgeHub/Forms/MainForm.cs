
using System;
using System.Windows.Forms;
using BridgeHub.Controls;
using BridgeHub.Forms;
using MetroFramework.Forms;

namespace BridgeHub
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            
            int devices = 5;
            int rows = (int) Math.Ceiling((devices / 2f));

            for (int row = 0; row < rows; row++)
            {
                this.DashbordLayout.RowCount += 1;

                for (int column = 0; column < 2; column++)
                {
                    Console.WriteLine("ROW:" + row);
                    this.DashbordLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    this.DashbordLayout.Controls.Add(new LightDashboardControl()
                    {
                        Anchor = (AnchorStyles.Left | AnchorStyles.Right)

                    }, column, this.DashbordLayout.RowCount - 1);
                }
            }
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
