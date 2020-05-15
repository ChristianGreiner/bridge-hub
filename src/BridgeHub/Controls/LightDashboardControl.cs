using BridgeHub.Core;
using BridgeHub.Forms;
using MetroFramework.Controls;

namespace BridgeHub.Controls
{
    public partial class LightDashboardControl : MetroUserControl
    {
        private int lightId;
        private Light light;
        
        public LightDashboardControl(int lightId)
        {
            this.lightId = lightId;

            InitializeComponent();

            this.light = BridgeApi.GetLight(lightId);

            this.DeviceName.Text = light.Name;
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
    }
}
