using System;
using RestSharp;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace BridgeHub.Forms
{
    public partial class LightForm : MetroForm
    {
        private bool dragging = false;

        public LightForm()
        {
            InitializeComponent();
        }

        private void ColorWheel_ColorChanged(object sender, EventArgs e)
        {
            // Send HTTP Request
        }

        private void OnToggle_CheckedChanged(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost/api/2987683a38804f3787fe19781175e6f3/lights/100");
            
            var request = new RestRequest("state", DataFormat.Json);
            request.AddHeader("Content-type", "application/json");

            var body = new { on = this.OnToggle.Checked} ;
            var json = JsonConvert.SerializeObject(body);

            Console.WriteLine(json);

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            var response = client.Put(request);
            
            Console.WriteLine(response.Content);
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

                var client = new RestClient("http://localhost/api/2987683a38804f3787fe19781175e6f3/lights/100");

                var request = new RestRequest("state", Method.PUT, DataFormat.Json);
                request.AddHeader("Content-type", "application/json");

                var body = new { bri = this.BrightnessSlider.Value };
                var json = JsonConvert.SerializeObject(body);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                var response = await client.ExecuteTaskAsync(request);
            }
        }
    }
}
