using BridgeHub.Controls;
using BridgeHub.Core;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BridgeHub.Forms
{
    public partial class MainForm : MetroForm
    {
        private readonly Dictionary<int, LightDashboardControl> lightControls;

        public MainForm()
        {
            InitializeComponent();

            this.lightControls = new Dictionary<int, LightDashboardControl>();
            this.FocusMe();

            this.RefreshTimer.Start();
        }

        private async void FetchLights()
        {
            this.LoadingSpinner.Visible = true;

            var lights = await BridgeApi.GetLights();

            // If new light added
            if (lightControls.Count != lights.Count)
            {
                this.lightControls.Clear();
                this.DashbordLayout.Controls.Clear();
                int rows = (int)Math.Ceiling((lights.Count / 2f));
                int lightIndex = 0;
                for (int row = 0; row < rows; row++)
                {
                    this.DashbordLayout.RowCount += 1;

                    this.DashbordLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    for (int i = 0; i < 2; i++)
                    {
                        if (lightIndex < lights.Count)
                        {
                            var lightControl = new LightDashboardControl(lights[lightIndex].Id)
                            {
                                Anchor = (AnchorStyles.Left | AnchorStyles.Right)
                            };

                            this.lightControls.Add(lights[lightIndex].Id, lightControl);
                            this.DashbordLayout.Controls.Add(lightControl, i, this.DashbordLayout.RowCount - 1);

                            lightIndex++;
                        }
                    }
                }
            }
            else
            {
                // just update values
                foreach (var light in lights)
                {
                    if (this.lightControls.ContainsKey(light.Id))
                    {
                        this.lightControls[light.Id].UpdateValues(light);
                        this.lightControls[light.Id].Invalidate();
                    }
                }
            }

            this.LoadingSpinner.Visible = false;
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

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FetchLights();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            FetchLights();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FetchLights();
        }
    }
}