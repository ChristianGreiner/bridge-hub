
using System;
using System.Windows.Forms;
using BridgeHub.Controls;
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
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}
