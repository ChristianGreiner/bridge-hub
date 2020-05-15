namespace BridgeHub.Forms
{
    partial class LightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightForm));
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.OnToggle = new MetroFramework.Controls.MetroToggle();
            this.ColorWheel = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.BrightnessSlider = new MetroFramework.Controls.MetroTrackBar();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Highlight = false;
            this.SaveButton.Location = new System.Drawing.Point(245, 408);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 36);
            this.SaveButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaveButton.StyleManager = null;
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // OnToggle
            // 
            this.OnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnToggle.AutoSize = true;
            this.OnToggle.CustomBackground = false;
            this.OnToggle.DisplayStatus = false;
            this.OnToggle.FontSize = MetroFramework.MetroLinkSize.Small;
            this.OnToggle.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.OnToggle.Location = new System.Drawing.Point(293, 63);
            this.OnToggle.Name = "OnToggle";
            this.OnToggle.Size = new System.Drawing.Size(50, 17);
            this.OnToggle.Style = MetroFramework.MetroColorStyle.Blue;
            this.OnToggle.StyleManager = null;
            this.OnToggle.TabIndex = 4;
            this.OnToggle.Text = "~StatusOff";
            this.OnToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OnToggle.UseStyleColors = false;
            this.OnToggle.UseVisualStyleBackColor = true;
            this.OnToggle.CheckedChanged += new System.EventHandler(this.OnToggle_CheckedChanged);
            // 
            // ColorWheel
            // 
            this.ColorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorWheel.Location = new System.Drawing.Point(23, 148);
            this.ColorWheel.Name = "ColorWheel";
            this.ColorWheel.Size = new System.Drawing.Size(257, 229);
            this.ColorWheel.TabIndex = 0;
            this.ColorWheel.Text = "colorWheel1";
            this.ColorWheel.ColorChanged += new System.EventHandler(this.ColorWheel_ColorChanged);
            // 
            // BrightnessSlider
            // 
            this.BrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessSlider.BackColor = System.Drawing.Color.Transparent;
            this.BrightnessSlider.CustomBackground = false;
            this.BrightnessSlider.LargeChange = ((uint)(10u));
            this.BrightnessSlider.Location = new System.Drawing.Point(23, 106);
            this.BrightnessSlider.Maximum = 254;
            this.BrightnessSlider.Minimum = 0;
            this.BrightnessSlider.MouseWheelBarPartitions = 10;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(342, 23);
            this.BrightnessSlider.SmallChange = ((uint)(1u));
            this.BrightnessSlider.Style = MetroFramework.MetroColorStyle.Blue;
            this.BrightnessSlider.StyleManager = null;
            this.BrightnessSlider.TabIndex = 5;
            this.BrightnessSlider.Text = "Brightness";
            this.BrightnessSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BrightnessSlider.Value = 254;
            this.BrightnessSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BrightnessSlider_Scroll);
            this.BrightnessSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightnessSlider_MouseUp);
            // 
            // LightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 467);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.OnToggle);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ColorWheel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LightForm";
            this.Text = "LIGHT NAME 123";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel ColorWheel;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroToggle OnToggle;
        private MetroFramework.Controls.MetroTrackBar BrightnessSlider;
    }
}