using BridgeHub.Core;
using BridgeHub.Forms;
using MetroFramework.Controls;

namespace BridgeHub.Controls
{
    public partial class LightDashboardControl : MetroUserControl
    {
        private bool dragging = false;
        private int lightId;
        private Light light;

        public LightDashboardControl(int lightId)
        {
            this.lightId = lightId;

            InitializeComponent();

            this.light = BridgeApi.GetLight(lightId);
            this.DeviceName.Text = light.Name;
            this.OnToggle.Checked = light.On;
            this.BrightnessSlider.Value = light.Brightness;
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
            LightForm lightForm = new LightForm(this.lightId);
            lightForm.ShowDialog(this);
        }

        private async void OnToggle_CheckedChanged(object sender, System.EventArgs e)
        {
            await BridgeApi.SetOn(this.lightId, this.OnToggle.Checked);
        }

        private async void BrightnessSlider_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.dragging)
            {
                this.dragging = false;

                await BridgeApi.SetBrightness(this.lightId, this.BrightnessSlider.Value);
            }
        }

        private void BrightnessSlider_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            this.dragging = true;
        }
    }
}