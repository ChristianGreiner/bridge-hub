using System.Windows.Forms;
using BridgeHub.Core;
using MetroFramework.Forms;

namespace BridgeHub.Forms
{
    public partial class LightDetailsForm : MetroForm
    {
        private readonly Light light;
        public LightDetailsForm(Light light)
        {
            this.light = light;

            InitializeComponent();

            this.UniqueIdTextBox.Text = this.light.UniqueId;
            this.ProductIdTextBox.Text = this.light.ProductId;
            this.ManufacturerNameTextBox.Text = this.light.ManufacturerName;
            this.TypeTextBox.Text = this.light.Type;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
