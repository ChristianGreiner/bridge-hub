namespace BridgeHub.Controls
{
    partial class LightDashboardControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightDashboardControl));
            this.DeviceTitle = new MetroFramework.Controls.MetroLabel();
            this.stateImage = new System.Windows.Forms.PictureBox();
            this.BrightnessSlider = new MetroFramework.Controls.MetroTrackBar();
            this.OnToggle = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.stateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceTitle
            // 
            this.DeviceTitle.AutoSize = true;
            this.DeviceTitle.CustomBackground = true;
            this.DeviceTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DeviceTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DeviceTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.DeviceTitle.Location = new System.Drawing.Point(51, 16);
            this.DeviceTitle.Name = "DeviceTitle";
            this.DeviceTitle.Size = new System.Drawing.Size(80, 25);
            this.DeviceTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeviceTitle.StyleManager = null;
            this.DeviceTitle.TabIndex = 0;
            this.DeviceTitle.Text = "Light 01";
            this.DeviceTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeviceTitle.UseStyleColors = false;
            // 
            // stateImage
            // 
            this.stateImage.BackColor = System.Drawing.Color.Transparent;
            this.stateImage.Image = ((System.Drawing.Image)(resources.GetObject("stateImage.Image")));
            this.stateImage.Location = new System.Drawing.Point(13, 13);
            this.stateImage.Name = "stateImage";
            this.stateImage.Size = new System.Drawing.Size(32, 32);
            this.stateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stateImage.TabIndex = 1;
            this.stateImage.TabStop = false;
            // 
            // BrightnessSlider
            // 
            this.BrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BrightnessSlider.CustomBackground = true;
            this.BrightnessSlider.LargeChange = ((uint)(5u));
            this.BrightnessSlider.Location = new System.Drawing.Point(13, 51);
            this.BrightnessSlider.Maximum = 100;
            this.BrightnessSlider.Minimum = 0;
            this.BrightnessSlider.MouseWheelBarPartitions = 10;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(274, 23);
            this.BrightnessSlider.SmallChange = ((uint)(1u));
            this.BrightnessSlider.Style = MetroFramework.MetroColorStyle.Blue;
            this.BrightnessSlider.StyleManager = null;
            this.BrightnessSlider.TabIndex = 2;
            this.BrightnessSlider.Text = "Brightness";
            this.BrightnessSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BrightnessSlider.Value = 50;
            // 
            // OnToggle
            // 
            this.OnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnToggle.AutoSize = true;
            this.OnToggle.CustomBackground = false;
            this.OnToggle.DisplayStatus = false;
            this.OnToggle.FontSize = MetroFramework.MetroLinkSize.Small;
            this.OnToggle.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.OnToggle.Location = new System.Drawing.Point(237, 22);
            this.OnToggle.Name = "OnToggle";
            this.OnToggle.Size = new System.Drawing.Size(50, 17);
            this.OnToggle.Style = MetroFramework.MetroColorStyle.Blue;
            this.OnToggle.StyleManager = null;
            this.OnToggle.TabIndex = 3;
            this.OnToggle.Text = "~StatusOff";
            this.OnToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OnToggle.UseStyleColors = false;
            this.OnToggle.UseVisualStyleBackColor = true;
            // 
            // LightDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.OnToggle);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.stateImage);
            this.Controls.Add(this.DeviceTitle);
            this.CustomBackground = true;
            this.Name = "LightDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(300, 85);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.stateImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel DeviceTitle;
        private System.Windows.Forms.PictureBox stateImage;
        private MetroFramework.Controls.MetroTrackBar BrightnessSlider;
        private MetroFramework.Controls.MetroToggle OnToggle;
    }
}
