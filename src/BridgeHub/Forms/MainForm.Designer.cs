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
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashbordLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.RefreshButton = new System.Windows.Forms.PictureBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayContextMenu.SuspendLayout();
            this.LightsContextMenu.SuspendLayout();
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
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Bridge Hub";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.LightsMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
            this.TrayContextMenu.Name = "contextMenuStrip1";
            this.TrayContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TrayContextMenu.ShowImageMargin = false;
            this.TrayContextMenu.Size = new System.Drawing.Size(142, 76);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.OpenMenuItem.ForeColor = System.Drawing.Color.White;
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(141, 22);
            this.OpenMenuItem.Text = "Open Bridge Hup";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // LightsMenuItem
            // 
            this.LightsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.LightsMenuItem.DropDown = this.LightsContextMenu;
            this.LightsMenuItem.ForeColor = System.Drawing.Color.White;
            this.LightsMenuItem.Name = "LightsMenuItem";
            this.LightsMenuItem.Size = new System.Drawing.Size(141, 22);
            this.LightsMenuItem.Text = "Lights";
            // 
            // LightsContextMenu
            // 
            this.LightsContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.LightsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadingMenuItem});
            this.LightsContextMenu.Name = "TrayMenu";
            this.LightsContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.LightsContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // LoadingMenuItem
            // 
            this.LoadingMenuItem.ForeColor = System.Drawing.Color.White;
            this.LoadingMenuItem.Name = "LoadingMenuItem";
            this.LoadingMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadingMenuItem.Text = "Loading ...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ExitMenuItem.Text = "Exit";
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
            this.TrayContextMenu.ResumeLayout(false);
            this.LightsContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton SettingsButton;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.TableLayoutPanel DashbordLayout;
        private MetroFramework.Controls.MetroProgressSpinner LoadingSpinner;
        private System.Windows.Forms.PictureBox RefreshButton;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ContextMenuStrip LightsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadingMenuItem;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightsMenuItem;
    }
}

