using BridgeHub.Core;
using MetroFramework.Forms;
using System;

namespace BridgeHub.Forms
{
    public partial class LightForm : MetroForm
    {
        private Light light;

        public LightForm(Light light)
        {
            this.light = light;
            InitializeComponent();
        }

        private void ColorWheel_ColorChanged(object sender, EventArgs e)
        {
            // Send HTTP Request
        }

        private async void OnToggle_CheckedChanged(object sender, System.EventArgs e)
        {
            await BridgeApi.SetOn(this.light.Id, this.OnToggle.Checked);
        }

        private async void BrightnessSlider_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            await BridgeApi.SetBrightness(this.light.Id, this.BrightnessSlider.Value);
        }

        private void LightForm_Load(object sender, EventArgs e)
        {
            this.Text = this.light.Name;
            this.OnToggle.Checked = this.light.On;
            this.BrightnessSlider.Value = this.light.Brightness;
            this.ColorWheel.Enabled = this.light.Color != null;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}