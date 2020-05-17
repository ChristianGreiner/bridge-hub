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
            this.BrightnessSlider = new MetroFramework.Controls.MetroTrackBar();
            this.ColorWheel = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(157, 425);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 36);
            this.SaveButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OnToggle
            // 
            this.OnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnToggle.AutoSize = true;
            this.OnToggle.DisplayStatus = false;
            this.OnToggle.Location = new System.Drawing.Point(231, 34);
            this.OnToggle.Name = "OnToggle";
            this.OnToggle.Size = new System.Drawing.Size(50, 17);
            this.OnToggle.Style = MetroFramework.MetroColorStyle.Blue;
            this.OnToggle.TabIndex = 4;
            this.OnToggle.Text = "Aus";
            this.OnToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OnToggle.UseSelectable = true;
            this.OnToggle.CheckedChanged += new System.EventHandler(this.OnToggle_CheckedChanged);
            // 
            // BrightnessSlider
            // 
            this.BrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessSlider.BackColor = System.Drawing.Color.Transparent;
            this.BrightnessSlider.Location = new System.Drawing.Point(27, 93);
            this.BrightnessSlider.Maximum = 255;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(254, 23);
            this.BrightnessSlider.Style = MetroFramework.MetroColorStyle.Blue;
            this.BrightnessSlider.TabIndex = 5;
            this.BrightnessSlider.Text = "Brightness";
            this.BrightnessSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BrightnessSlider.Value = 254;
            this.BrightnessSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightnessSlider_MouseUp);
            // 
            // ColorWheel
            // 
            this.ColorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorWheel.Enabled = false;
            this.ColorWheel.Location = new System.Drawing.Point(27, 151);
            this.ColorWheel.Name = "ColorWheel";
            this.ColorWheel.Size = new System.Drawing.Size(250, 250);
            this.ColorWheel.TabIndex = 0;
            this.ColorWheel.Text = "ColorWheel";
            this.ColorWheel.ColorChanged += new System.EventHandler(this.ColorWheel_ColorChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Brightness";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Color";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 484);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.OnToggle);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ColorWheel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LightForm";
            this.Text = "LIGHT NAME";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.LightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel ColorWheel;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroToggle OnToggle;
        private MetroFramework.Controls.MetroTrackBar BrightnessSlider;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}