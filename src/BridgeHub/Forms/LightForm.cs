using System;
using BridgeHub.Core;
using RestSharp;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace BridgeHub.Forms
{
    public partial class LightForm : MetroForm
    {
        private bool dragging = false;
        private int lightId;
        private Light light;

        public LightForm(int lightId)
        {
            this.lightId = lightId;
            this.light = BridgeApi.GetLight(lightId);

            InitializeComponent();

            this.Text = this.light.Name;
            this.OnToggle.Checked = this.light.On;
        }

        private void ColorWheel_ColorChanged(object sender, EventArgs e)
        {
            // Send HTTP Request
        }

        private async void OnToggle_CheckedChanged(object sender, EventArgs e)
        {
            await BridgeApi.SetOn(this.lightId, this.OnToggle.Checked);
        }

        private void BrightnessSlider_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            this.dragging = true;
        }

        private async void BrightnessSlider_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.dragging)
            {
                this.dragging = false;

                await BridgeApi.SetBrightness(this.lightId, this.BrightnessSlider.Value);
            }
        }
    }
}
