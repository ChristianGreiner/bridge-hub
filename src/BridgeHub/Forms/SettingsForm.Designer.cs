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
            this.IPAdressLabel = new MetroFramework.Controls.MetroLabel();
            this.IPAdressTextbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Highlight = false;
            this.SaveButton.Location = new System.Drawing.Point(259, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 36);
            this.SaveButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaveButton.StyleManager = null;
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IPAdressLabel
            // 
            this.IPAdressLabel.AutoSize = true;
            //this.IPAdressLabel.CustomBackground = false;
            this.IPAdressLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.IPAdressLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.IPAdressLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.IPAdressLabel.Location = new System.Drawing.Point(23, 77);
            this.IPAdressLabel.Name = "IPAdressLabel";
            this.IPAdressLabel.Size = new System.Drawing.Size(65, 19);
            this.IPAdressLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.IPAdressLabel.StyleManager = null;
            this.IPAdressLabel.TabIndex = 3;
            this.IPAdressLabel.Text = "IP-Adress";
            this.IPAdressLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IPAdressLabel.UseStyleColors = false;
            // 
            // IPAdressTextbox
            // 
            this.IPAdressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAdressTextbox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.IPAdressTextbox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.IPAdressTextbox.Location = new System.Drawing.Point(26, 103);
            this.IPAdressTextbox.Multiline = false;
            this.IPAdressTextbox.Name = "IPAdressTextbox";
            this.IPAdressTextbox.SelectedText = "";
            this.IPAdressTextbox.Size = new System.Drawing.Size(353, 23);
            this.IPAdressTextbox.Style = MetroFramework.MetroColorStyle.Blue;
            this.IPAdressTextbox.StyleManager = null;
            this.IPAdressTextbox.TabIndex = 4;
            this.IPAdressTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IPAdressTextbox.UseStyleColors = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 339);
            this.Controls.Add(this.IPAdressTextbox);
            this.Controls.Add(this.IPAdressLabel);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroLabel IPAdressLabel;
        private MetroFramework.Controls.MetroTextBox IPAdressTextbox;
    }
}