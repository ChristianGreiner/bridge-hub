using System;
using System.Drawing;
using System.Windows.Forms;
using BridgeHub.Core;
using BridgeHub.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace BridgeHub.Controls
{
    public partial class LightDashboardControl : MetroUserControl
    {
        private readonly int lightId;
        private Light light;

        public LightDashboardControl(int lightId)
        {
            this.lightId = lightId;

            InitializeComponent();
        }

        private void StateImage_Click(object sender, System.EventArgs e)
        {
            ShowLightForm();
        }

        private void LightDashboardControl_Click(object sender, System.EventArgs e)
        {
            ShowLightForm();
        }

        private void ShowLightForm()
        {
            LightForm lightForm = new LightForm(this.light);
            lightForm.ShowDialog(this);
        }

        private async void OnToggle_CheckedChanged(object sender, System.EventArgs e)
        {
            this.light.On = this.OnToggle.Checked;
            await BridgeApi.SetOn(this.lightId, this.light.On);
        }

        private async void BrightnessSlider_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.light.Brightness = this.BrightnessSlider.Value;
            var success = await BridgeApi.SetBrightness(this.lightId, this.light.Brightness);
            if (!success)
                MetroMessageBox.Show(this, "The brightness could not been set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UpdateValues(Light light)
        {
            this.light = light;
            this.DeviceName.Text = this.light.Name;
            this.OnToggle.Checked = this.light.On;
            this.BrightnessSlider.Value = this.light.Brightness;
            if (this.light.Color != null)
            {
                var color = HueXY.ConvertXyToRgb(this.light.Color.X, this.light.Color.Y, 255f);
                this.LightColorIndicator.BackColor = color;
            }

        }
        private async void LightDashboardControl_Load(object sender, EventArgs e)
        {
            this.light = await BridgeApi.GetLight(lightId);
            this.UpdateValues(light);
        }

        private void DeviceName_Click(object sender, EventArgs e)
        {
            ShowLightForm();
        }
    }
}