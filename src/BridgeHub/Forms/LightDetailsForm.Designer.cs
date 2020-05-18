namespace BridgeHub.Forms
{
    partial class LightDetailsForm
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
            this.ManufacturerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.ManufacturerNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductIdLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UniqueIdLabel = new MetroFramework.Controls.MetroLabel();
            this.UniqueIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.TypeLabel = new MetroFramework.Controls.MetroLabel();
            this.TypeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // ManufacturerNameLabel
            // 
            this.ManufacturerNameLabel.AutoSize = true;
            this.ManufacturerNameLabel.Location = new System.Drawing.Point(23, 111);
            this.ManufacturerNameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ManufacturerNameLabel.Name = "ManufacturerNameLabel";
            this.ManufacturerNameLabel.Size = new System.Drawing.Size(87, 19);
            this.ManufacturerNameLabel.TabIndex = 19;
            this.ManufacturerNameLabel.Text = "Manufacturer";
            this.ManufacturerNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ManufacturerNameTextBox
            // 
            this.ManufacturerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ManufacturerNameTextBox.CustomButton.Image = null;
            this.ManufacturerNameTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.ManufacturerNameTextBox.CustomButton.Name = "";
            this.ManufacturerNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ManufacturerNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManufacturerNameTextBox.CustomButton.TabIndex = 1;
            this.ManufacturerNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManufacturerNameTextBox.CustomButton.UseSelectable = true;
            this.ManufacturerNameTextBox.CustomButton.Visible = false;
            this.ManufacturerNameTextBox.Lines = new string[0];
            this.ManufacturerNameTextBox.Location = new System.Drawing.Point(23, 136);
            this.ManufacturerNameTextBox.MaxLength = 32767;
            this.ManufacturerNameTextBox.Name = "ManufacturerNameTextBox";
            this.ManufacturerNameTextBox.PasswordChar = '\0';
            this.ManufacturerNameTextBox.ReadOnly = true;
            this.ManufacturerNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManufacturerNameTextBox.SelectedText = "";
            this.ManufacturerNameTextBox.SelectionLength = 0;
            this.ManufacturerNameTextBox.SelectionStart = 0;
            this.ManufacturerNameTextBox.ShortcutsEnabled = true;
            this.ManufacturerNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.ManufacturerNameTextBox.TabIndex = 18;
            this.ManufacturerNameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ManufacturerNameTextBox.UseSelectable = true;
            this.ManufacturerNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManufacturerNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(23, 165);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(70, 19);
            this.ProductIdLabel.TabIndex = 17;
            this.ProductIdLabel.Text = "Product Id";
            this.ProductIdLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductIdTextBox.CustomButton.Image = null;
            this.ProductIdTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.ProductIdTextBox.CustomButton.Name = "";
            this.ProductIdTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductIdTextBox.CustomButton.TabIndex = 1;
            this.ProductIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductIdTextBox.CustomButton.UseSelectable = true;
            this.ProductIdTextBox.CustomButton.Visible = false;
            this.ProductIdTextBox.Lines = new string[0];
            this.ProductIdTextBox.Location = new System.Drawing.Point(23, 190);
            this.ProductIdTextBox.MaxLength = 32767;
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.PasswordChar = '\0';
            this.ProductIdTextBox.ReadOnly = true;
            this.ProductIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductIdTextBox.SelectedText = "";
            this.ProductIdTextBox.SelectionLength = 0;
            this.ProductIdTextBox.SelectionStart = 0;
            this.ProductIdTextBox.ShortcutsEnabled = true;
            this.ProductIdTextBox.Size = new System.Drawing.Size(250, 23);
            this.ProductIdTextBox.TabIndex = 16;
            this.ProductIdTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProductIdTextBox.UseSelectable = true;
            this.ProductIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UniqueIdLabel
            // 
            this.UniqueIdLabel.AutoSize = true;
            this.UniqueIdLabel.Location = new System.Drawing.Point(23, 60);
            this.UniqueIdLabel.Name = "UniqueIdLabel";
            this.UniqueIdLabel.Size = new System.Drawing.Size(65, 19);
            this.UniqueIdLabel.TabIndex = 15;
            this.UniqueIdLabel.Text = "Unique Id";
            this.UniqueIdLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UniqueIdTextBox
            // 
            this.UniqueIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.UniqueIdTextBox.CustomButton.Image = null;
            this.UniqueIdTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.UniqueIdTextBox.CustomButton.Name = "";
            this.UniqueIdTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UniqueIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UniqueIdTextBox.CustomButton.TabIndex = 1;
            this.UniqueIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UniqueIdTextBox.CustomButton.UseSelectable = true;
            this.UniqueIdTextBox.CustomButton.Visible = false;
            this.UniqueIdTextBox.Lines = new string[0];
            this.UniqueIdTextBox.Location = new System.Drawing.Point(23, 82);
            this.UniqueIdTextBox.MaxLength = 32767;
            this.UniqueIdTextBox.Name = "UniqueIdTextBox";
            this.UniqueIdTextBox.PasswordChar = '\0';
            this.UniqueIdTextBox.ReadOnly = true;
            this.UniqueIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UniqueIdTextBox.SelectedText = "";
            this.UniqueIdTextBox.SelectionLength = 0;
            this.UniqueIdTextBox.SelectionStart = 0;
            this.UniqueIdTextBox.ShortcutsEnabled = true;
            this.UniqueIdTextBox.Size = new System.Drawing.Size(250, 23);
            this.UniqueIdTextBox.TabIndex = 14;
            this.UniqueIdTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UniqueIdTextBox.UseSelectable = true;
            this.UniqueIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UniqueIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(188, 283);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 32);
            this.CloseButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CloseButton.TabIndex = 20;
            this.CloseButton.Text = "Close";
            this.CloseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(23, 219);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(36, 19);
            this.TypeLabel.TabIndex = 22;
            this.TypeLabel.Text = "Type";
            this.TypeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TypeTextBox.CustomButton.Image = null;
            this.TypeTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.TypeTextBox.CustomButton.Name = "";
            this.TypeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TypeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TypeTextBox.CustomButton.TabIndex = 1;
            this.TypeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TypeTextBox.CustomButton.UseSelectable = true;
            this.TypeTextBox.CustomButton.Visible = false;
            this.TypeTextBox.Lines = new string[0];
            this.TypeTextBox.Location = new System.Drawing.Point(23, 244);
            this.TypeTextBox.MaxLength = 32767;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.PasswordChar = '\0';
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TypeTextBox.SelectedText = "";
            this.TypeTextBox.SelectionLength = 0;
            this.TypeTextBox.SelectionStart = 0;
            this.TypeTextBox.ShortcutsEnabled = true;
            this.TypeTextBox.Size = new System.Drawing.Size(250, 23);
            this.TypeTextBox.TabIndex = 21;
            this.TypeTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TypeTextBox.UseSelectable = true;
            this.TypeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TypeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LightDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 338);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ManufacturerNameLabel);
            this.Controls.Add(this.ManufacturerNameTextBox);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.UniqueIdLabel);
            this.Controls.Add(this.UniqueIdTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LightDetailsForm";
            this.Resizable = false;
            this.Text = "Details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ManufacturerNameLabel;
        private MetroFramework.Controls.MetroTextBox ManufacturerNameTextBox;
        private MetroFramework.Controls.MetroLabel ProductIdLabel;
        private MetroFramework.Controls.MetroTextBox ProductIdTextBox;
        private MetroFramework.Controls.MetroLabel UniqueIdLabel;
        private MetroFramework.Controls.MetroTextBox UniqueIdTextBox;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroLabel TypeLabel;
        private MetroFramework.Controls.MetroTextBox TypeTextBox;
    }
}