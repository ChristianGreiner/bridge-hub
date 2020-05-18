namespace BridgeHub.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.BridgeServerLabel = new MetroFramework.Controls.MetroLabel();
            this.BridgeServerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UpdateIntervalLabel = new MetroFramework.Controls.MetroLabel();
            this.UpdateIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.IpAdressToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateIntervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(99, 178);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 32);
            this.SaveButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BridgeServerLabel
            // 
            this.BridgeServerLabel.AutoSize = true;
            this.BridgeServerLabel.Location = new System.Drawing.Point(23, 60);
            this.BridgeServerLabel.Name = "BridgeServerLabel";
            this.BridgeServerLabel.Size = new System.Drawing.Size(90, 19);
            this.BridgeServerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.BridgeServerLabel.TabIndex = 3;
            this.BridgeServerLabel.Text = "Bridge Server";
            this.BridgeServerLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BridgeServerTextBox
            // 
            this.BridgeServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.BridgeServerTextBox.CustomButton.Image = null;
            this.BridgeServerTextBox.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.BridgeServerTextBox.CustomButton.Name = "";
            this.BridgeServerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BridgeServerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BridgeServerTextBox.CustomButton.TabIndex = 1;
            this.BridgeServerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BridgeServerTextBox.CustomButton.UseSelectable = true;
            this.BridgeServerTextBox.CustomButton.Visible = false;
            this.BridgeServerTextBox.Lines = new string[] {
        "localhost/api/devices"};
            this.BridgeServerTextBox.Location = new System.Drawing.Point(26, 85);
            this.BridgeServerTextBox.MaxLength = 32767;
            this.BridgeServerTextBox.Name = "BridgeServerTextBox";
            this.BridgeServerTextBox.PasswordChar = '\0';
            this.BridgeServerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BridgeServerTextBox.SelectedText = "";
            this.BridgeServerTextBox.SelectionLength = 0;
            this.BridgeServerTextBox.SelectionStart = 0;
            this.BridgeServerTextBox.ShortcutsEnabled = true;
            this.BridgeServerTextBox.Size = new System.Drawing.Size(158, 23);
            this.BridgeServerTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.BridgeServerTextBox.TabIndex = 4;
            this.BridgeServerTextBox.Text = "localhost/api/devices";
            this.BridgeServerTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BridgeServerTextBox.UseSelectable = true;
            this.BridgeServerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BridgeServerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdateIntervalLabel
            // 
            this.UpdateIntervalLabel.AutoSize = true;
            this.UpdateIntervalLabel.Location = new System.Drawing.Point(23, 114);
            this.UpdateIntervalLabel.Name = "UpdateIntervalLabel";
            this.UpdateIntervalLabel.Size = new System.Drawing.Size(131, 19);
            this.UpdateIntervalLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.UpdateIntervalLabel.TabIndex = 5;
            this.UpdateIntervalLabel.Text = "Update Inverval (sec)";
            this.UpdateIntervalLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UpdateIntervalUpDown
            // 
            this.UpdateIntervalUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateIntervalUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.UpdateIntervalUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateIntervalUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UpdateIntervalUpDown.ForeColor = System.Drawing.Color.White;
            this.UpdateIntervalUpDown.Location = new System.Drawing.Point(26, 136);
            this.UpdateIntervalUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateIntervalUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.UpdateIntervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpdateIntervalUpDown.Name = "UpdateIntervalUpDown";
            this.UpdateIntervalUpDown.Size = new System.Drawing.Size(156, 23);
            this.UpdateIntervalUpDown.TabIndex = 6;
            this.UpdateIntervalUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // IpAdressToolTip
            // 
            this.IpAdressToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.IpAdressToolTip.StyleManager = null;
            this.IpAdressToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 233);
            this.Controls.Add(this.UpdateIntervalUpDown);
            this.Controls.Add(this.UpdateIntervalLabel);
            this.Controls.Add(this.BridgeServerTextBox);
            this.Controls.Add(this.BridgeServerLabel);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.UpdateIntervalUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroLabel BridgeServerLabel;
        private MetroFramework.Controls.MetroTextBox BridgeServerTextBox;
        private MetroFramework.Controls.MetroLabel UpdateIntervalLabel;
        private System.Windows.Forms.NumericUpDown UpdateIntervalUpDown;
        private MetroFramework.Components.MetroToolTip IpAdressToolTip;
    }
}