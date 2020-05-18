using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BridgeHub.Forms
{
    public partial class SettingsForm : MetroForm
    {
        private readonly Regex ipRegex = new Regex("^(localhost|(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))(:([0-9]|[1-9][0-9]|[1-9][0-9]{2}|[1-9][0-9]{3}|[1-5][0-9]{4}|6([0-4][0-9]{3}|5([0-4][0-9]{2}|5([0-2][0-9]|3[0-5])))))?$");

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.ipRegex.IsMatch(this.IpAdressTextbox.Text))
            {
                // TODO: Save settings
                this.Close();
            }
            else MetroMessageBox.Show(this, "IP-Adress isn't in the correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}