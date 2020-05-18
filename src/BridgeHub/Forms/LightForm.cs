using BridgeHub.Core;
using MetroFramework.Forms;
using System;
using BridgeHub.Extensions;

namespace BridgeHub.Forms
{
    public partial class LightForm : MetroForm
    {
        private readonly Light light;

        public LightForm(Light light)
        {
            this.light = light;
            InitializeComponent();
        }

        private  void ColorWheel_ColorChanged(object sender, EventArgs e)
        {
            this.LightColorIndicator.BackColor = this.ColorWheel.Color;
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
            this.Text = this.light.Name.Truncate(14);
            this.OnToggle.Checked = this.light.On;
            this.BrightnessSlider.Value = this.light.Brightness;
            this.ColorWheel.Enabled = this.light.Color != null;
            
            if (this.light.Color != null)
            {
                this.ColorWheel.Color = light.Color.ToRgb();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            LightDetailsForm detailsForm = new LightDetailsForm(this.light);
            detailsForm.ShowDialog(this);
        }

        private async void ColorWheel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var color = this.ColorWheel.Color;
            await BridgeApi.SetColor(this.light.Id, color.R, color.G, color.B);
        }
    }
}