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
            this.DeviceName = new MetroFramework.Controls.MetroLabel();
            this.StateImage = new System.Windows.Forms.PictureBox();
            this.BrightnessSlider = new MetroFramework.Controls.MetroTrackBar();
            this.OnToggle = new MetroFramework.Controls.MetroToggle();
            this.LightColorIndicator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSize = true;
            this.DeviceName.CustomBackground = true;
            this.DeviceName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DeviceName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DeviceName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.DeviceName.Location = new System.Drawing.Point(51, 13);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(80, 25);
            this.DeviceName.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeviceName.StyleManager = null;
            this.DeviceName.TabIndex = 0;
            this.DeviceName.Text = "Light 01";
            this.DeviceName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeviceName.UseStyleColors = false;
            // 
            // StateImage
            // 
            this.StateImage.BackColor = System.Drawing.Color.Transparent;
            this.StateImage.Image = ((System.Drawing.Image)(resources.GetObject("StateImage.Image")));
            this.StateImage.Location = new System.Drawing.Point(16, 6);
            this.StateImage.Name = "StateImage";
            this.StateImage.Size = new System.Drawing.Size(32, 32);
            this.StateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StateImage.TabIndex = 1;
            this.StateImage.TabStop = false;
            this.StateImage.Click += new System.EventHandler(this.StateImage_Click);
            // 
            // BrightnessSlider
            // 
            this.BrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BrightnessSlider.CustomBackground = true;
            this.BrightnessSlider.LargeChange = ((uint)(5u));
            this.BrightnessSlider.Location = new System.Drawing.Point(16, 51);
            this.BrightnessSlider.Maximum = 254;
            this.BrightnessSlider.Minimum = 0;
            this.BrightnessSlider.MouseWheelBarPartitions = 10;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(271, 23);
            this.BrightnessSlider.SmallChange = ((uint)(1u));
            this.BrightnessSlider.Style = MetroFramework.MetroColorStyle.Blue;
            this.BrightnessSlider.StyleManager = null;
            this.BrightnessSlider.TabIndex = 2;
            this.BrightnessSlider.Text = "Brightness";
            this.BrightnessSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BrightnessSlider.Value = 254;
            this.BrightnessSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BrightnessSlider_Scroll);
            this.BrightnessSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightnessSlider_MouseUp);
            // 
            // OnToggle
            // 
            this.OnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnToggle.AutoSize = true;
            this.OnToggle.CustomBackground = false;
            this.OnToggle.DisplayStatus = false;
            this.OnToggle.FontSize = MetroFramework.MetroLinkSize.Small;
            this.OnToggle.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.OnToggle.Location = new System.Drawing.Point(237, 12);
            this.OnToggle.Name = "OnToggle";
            this.OnToggle.Size = new System.Drawing.Size(50, 17);
            this.OnToggle.Style = MetroFramework.MetroColorStyle.Blue;
            this.OnToggle.StyleManager = null;
            this.OnToggle.TabIndex = 3;
            this.OnToggle.Text = "~StatusOff";
            this.OnToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OnToggle.UseStyleColors = false;
            this.OnToggle.UseVisualStyleBackColor = true;
            this.OnToggle.CheckedChanged += new System.EventHandler(this.OnToggle_CheckedChanged);
            // 
            // LightColorIndicator
            // 
            this.LightColorIndicator.BackColor = System.Drawing.Color.White;
            this.LightColorIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightColorIndicator.Location = new System.Drawing.Point(0, 0);
            this.LightColorIndicator.Name = "LightColorIndicator";
            this.LightColorIndicator.Size = new System.Drawing.Size(5, 85);
            this.LightColorIndicator.TabIndex = 4;
            // 
            // LightDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.LightColorIndicator);
            this.Controls.Add(this.OnToggle);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.StateImage);
            this.Controls.Add(this.DeviceName);
            this.CustomBackground = true;
            this.Name = "LightDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Size = new System.Drawing.Size(300, 85);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Click += new System.EventHandler(this.LightDashboardControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.StateImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel DeviceName;
        private System.Windows.Forms.PictureBox StateImage;
        private MetroFramework.Controls.MetroTrackBar BrightnessSlider;
        private MetroFramework.Controls.MetroToggle OnToggle;
        private System.Windows.Forms.Panel LightColorIndicator;
    }
}
