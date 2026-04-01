namespace WindowsLab
{
    partial class WindowFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowFrom));
            System.Windows.Forms.PictureBox pictureBox2;
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMain = new System.Windows.Forms.Label();
            this.panelSider = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnSettings = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSyn = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.flpRight.SuspendLayout();
            this.flpLeft.SuspendLayout();
            this.panelSider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 565);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1201, 26);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.flpRight);
            this.panelHeader.Controls.Add(this.flpLeft);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1201, 93);
            this.panelHeader.TabIndex = 1;
            // 
            // flpRight
            // 
            this.flpRight.Controls.Add(this.labelAdmin);
            this.flpRight.Controls.Add(this.pictureBox1);
            this.flpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpRight.Location = new System.Drawing.Point(1007, 0);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(194, 93);
            this.flpRight.TabIndex = 0;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAdmin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelAdmin.Location = new System.Drawing.Point(110, 16);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(3, 16, 12, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.labelAdmin.Size = new System.Drawing.Size(72, 53);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Admin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpLeft
            // 
            this.flpLeft.Controls.Add(this.labelMain);
            this.flpLeft.Controls.Add(pictureBox2);
            this.flpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLeft.Location = new System.Drawing.Point(0, 0);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(346, 93);
            this.flpLeft.TabIndex = 0;
            // 
            // labelMain
            // 
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMain.Location = new System.Drawing.Point(12, 30);
            this.labelMain.Margin = new System.Windows.Forms.Padding(12, 30, 0, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(215, 37);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Mini Store - Back Office";
            // 
            // panelSider
            // 
            this.panelSider.Controls.Add(this.btnSettings);
            this.panelSider.Controls.Add(this.BtnReports);
            this.panelSider.Controls.Add(this.btnLogs);
            this.panelSider.Controls.Add(this.btnSyn);
            this.panelSider.Controls.Add(this.btnProducts);
            this.panelSider.Controls.Add(this.btnOrders);
            this.panelSider.Controls.Add(this.btnDashboard);
            this.panelSider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSider.Location = new System.Drawing.Point(0, 93);
            this.panelSider.Name = "panelSider";
            this.panelSider.Size = new System.Drawing.Size(229, 472);
            this.panelSider.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(229, 93);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(972, 472);
            this.panelContent.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(55, 317);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(145, 39);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnReports.FlatAppearance.BorderSize = 0;
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.Image = ((System.Drawing.Image)(resources.GetObject("BtnReports.Image")));
            this.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReports.Location = new System.Drawing.Point(64, 164);
            this.BtnReports.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(145, 39);
            this.BtnReports.TabIndex = 5;
            this.BtnReports.Text = "Reports";
            this.BtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReports.UseVisualStyleBackColor = true;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.Image = global::WindowsLab.Properties.Resources.logs1;
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogs.Location = new System.Drawing.Point(55, 266);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(145, 39);
            this.btnLogs.TabIndex = 4;
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.BtnLogs_Click);
            // 
            // btnSyn
            // 
            this.btnSyn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSyn.FlatAppearance.BorderSize = 0;
            this.btnSyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyn.Image = ((System.Drawing.Image)(resources.GetObject("btnSyn.Image")));
            this.btnSyn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSyn.Location = new System.Drawing.Point(64, 215);
            this.btnSyn.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.Size = new System.Drawing.Size(145, 39);
            this.btnSyn.TabIndex = 3;
            this.btnSyn.Text = "Syn";
            this.btnSyn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyn.UseVisualStyleBackColor = true;
            this.btnSyn.Click += new System.EventHandler(this.BtnSyn_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.Location = new System.Drawing.Point(64, 62);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(145, 39);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.Location = new System.Drawing.Point(64, 113);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(145, 39);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(64, 7);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(145, 39);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.DashboardClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 16, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(228, 20);
            pictureBox2.Margin = new System.Windows.Forms.Padding(1, 20, 3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(43, 37);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // WindowFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 591);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSider);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.flpRight.ResumeLayout(false);
            this.flpRight.PerformLayout();
            this.flpLeft.ResumeLayout(false);
            this.panelSider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSider;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSyn;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelMain;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

