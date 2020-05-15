using BridgeHub.Forms;
using MetroFramework.Controls;

namespace BridgeHub.Controls
{
    public partial class LightDashboardControl : MetroUserControl
    {
        public LightDashboardControl()
        {
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
            LightForm lightForm = new LightForm();
            lightForm.ShowDialog(this);
        }
    }
}
