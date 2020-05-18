namespace BridgeHub.Forms
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SettingsButton = new MetroFramework.Controls.MetroButton();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToogleLightsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TestLightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashbordLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.RefreshButton = new System.Windows.Forms.PictureBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayMenu.SuspendLayout();
            this.LightsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Location = new System.Drawing.Point(562, 36);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(100, 24);
            this.SettingsButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SettingsButton.UseSelectable = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Bridge Hub";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.ToogleLightsMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TrayMenu.Size = new System.Drawing.Size(167, 76);
            // 
            // openMenuItem
            // 
            this.openMenuItem.ForeColor = System.Drawing.Color.White;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openMenuItem.Text = "Open Bridge Hub";
            // 
            // ToogleLightsMenuItem
            // 
            this.ToogleLightsMenuItem.DropDown = this.LightsMenu;
            this.ToogleLightsMenuItem.ForeColor = System.Drawing.Color.White;
            this.ToogleLightsMenuItem.Name = "ToogleLightsMenuItem";
            this.ToogleLightsMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ToogleLightsMenuItem.Text = "Toogle Lights";
            // 
            // LightsMenu
            // 
            this.LightsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.LightsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestLightMenuItem});
            this.LightsMenu.Name = "TrayMenu";
            this.LightsMenu.OwnerItem = this.ToogleLightsMenuItem;
            this.LightsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.LightsMenu.Size = new System.Drawing.Size(125, 26);
            // 
            // TestLightMenuItem
            // 
            this.TestLightMenuItem.ForeColor = System.Drawing.Color.White;
            this.TestLightMenuItem.Name = "TestLightMenuItem";
            this.TestLightMenuItem.Size = new System.Drawing.Size(124, 22);
            this.TestLightMenuItem.Text = "Test Light";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ExitMenuItem.Text = "Exit Bridge Hub";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // DashbordLayout
            // 
            this.DashbordLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashbordLayout.AutoScroll = true;
            this.DashbordLayout.ColumnCount = 2;
            this.DashbordLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashbordLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashbordLayout.Location = new System.Drawing.Point(23, 66);
            this.DashbordLayout.Name = "DashbordLayout";
            this.DashbordLayout.RowCount = 1;
            this.DashbordLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DashbordLayout.Size = new System.Drawing.Size(639, 446);
            this.DashbordLayout.TabIndex = 1;
            // 
            // LoadingSpinner
            // 
            this.LoadingSpinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingSpinner.Location = new System.Drawing.Point(310, 235);
            this.LoadingSpinner.Maximum = 100;
            this.LoadingSpinner.Name = "LoadingSpinner";
            this.LoadingSpinner.Size = new System.Drawing.Size(64, 64);
            this.LoadingSpinner.TabIndex = 2;
            this.LoadingSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoadingSpinner.UseSelectable = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(148, 28);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(20, 20);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 10000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 535);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LoadingSpinner);
            this.Controls.Add(this.DashbordLayout);
            this.Controls.Add(this.SettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Bridge Hub";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TrayMenu.ResumeLayout(false);
            this.LightsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton SettingsButton;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.TableLayoutPanel DashbordLayout;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private MetroFramework.Controls.MetroProgressSpinner LoadingSpinner;
        private System.Windows.Forms.PictureBox RefreshButton;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ToolStripMenuItem ToogleLightsMenuItem;
        private System.Windows.Forms.ContextMenuStrip LightsMenu;
        private System.Windows.Forms.ToolStripMenuItem TestLightMenuItem;
    }
}

