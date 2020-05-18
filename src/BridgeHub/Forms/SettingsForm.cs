using BridgeHub.Core;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BridgeHub.Forms
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            this.BridgeServerTextBox.Text = Settings.Instance.BridgeServer;
            this.UpdateIntervalUpDown.Value = Settings.Instance.UpdateInterval;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.BridgeServerTextBox.Text))
            {
                // save Settings
                Settings.Instance.BridgeServer = this.BridgeServerTextBox.Text;
                Settings.Instance.UpdateInterval = int.Parse(this.UpdateIntervalUpDown.Text);
                Settings.Instance.Save();

                this.Close();
            }
            else MetroMessageBox.Show(this, "No Bridge Server given.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}