namespace App.WindowApp
{
    partial class MainForm
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
            PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panelHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            labelAdmin = new Label();
            pictureBox1 = new PictureBox();
            flpLeft = new FlowLayoutPanel();
            labelMain = new Label();
            panelSider = new Panel();
            btnSettings = new Button();
            BtnReports = new Button();
            btnLogs = new Button();
            btnSyn = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnDashboard = new Button();
            panelContent = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            statusStrip.SuspendLayout();
            panelHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpLeft.SuspendLayout();
            panelSider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(228, 20);
            pictureBox2.Margin = new Padding(1, 20, 3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 482);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(848, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(flpRight);
            panelHeader.Controls.Add(flpLeft);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(848, 93);
            panelHeader.TabIndex = 1;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(labelAdmin);
            flpRight.Controls.Add(pictureBox1);
            flpRight.Dock = DockStyle.Right;
            flpRight.FlowDirection = FlowDirection.RightToLeft;
            flpRight.Location = new Point(654, 0);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(194, 93);
            flpRight.TabIndex = 0;
            // 
            // labelAdmin
            // 
            labelAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAdmin.AutoSize = true;
            labelAdmin.BorderStyle = BorderStyle.Fixed3D;
            labelAdmin.Cursor = Cursors.WaitCursor;
            labelAdmin.FlatStyle = FlatStyle.Flat;
            labelAdmin.ForeColor = SystemColors.ActiveCaptionText;
            labelAdmin.ImageAlign = ContentAlignment.BottomRight;
            labelAdmin.Location = new Point(121, 16);
            labelAdmin.Margin = new Padding(3, 16, 12, 0);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Padding = new Padding(5);
            labelAdmin.Size = new Size(61, 53);
            labelAdmin.TabIndex = 0;
            labelAdmin.Text = "Admin";
            labelAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(76, 16);
            pictureBox1.Margin = new Padding(2, 16, 0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(labelMain);
            flpLeft.Controls.Add(pictureBox2);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(346, 93);
            flpLeft.TabIndex = 0;
            // 
            // labelMain
            // 
            labelMain.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMain.ImageAlign = ContentAlignment.MiddleRight;
            labelMain.Location = new Point(12, 30);
            labelMain.Margin = new Padding(12, 30, 0, 0);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(215, 37);
            labelMain.TabIndex = 0;
            labelMain.Text = "Mini Store - Back Office";
            // 
            // panelSider
            // 
            panelSider.Controls.Add(btnSettings);
            panelSider.Controls.Add(BtnReports);
            panelSider.Controls.Add(btnLogs);
            panelSider.Controls.Add(btnSyn);
            panelSider.Controls.Add(btnProducts);
            panelSider.Controls.Add(btnOrders);
            panelSider.Controls.Add(btnDashboard);
            panelSider.Dock = DockStyle.Left;
            panelSider.Location = new Point(0, 93);
            panelSider.Name = "panelSider";
            panelSider.Size = new Size(229, 389);
            panelSider.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.AppStarting;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnSettings.Location = new Point(55, 317);
            btnSettings.Margin = new Padding(0, 8, 0, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(145, 39);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += BtnSettings_Click;
            // 
            // BtnReports
            // 
            BtnReports.Cursor = Cursors.AppStarting;
            BtnReports.FlatAppearance.BorderSize = 0;
            BtnReports.FlatStyle = FlatStyle.Flat;
            BtnReports.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReports.Image = (Image)resources.GetObject("BtnReports.Image");
            BtnReports.ImageAlign = ContentAlignment.MiddleRight;
            BtnReports.Location = new Point(64, 164);
            BtnReports.Margin = new Padding(0, 12, 0, 0);
            BtnReports.Name = "BtnReports";
            BtnReports.Size = new Size(145, 39);
            BtnReports.TabIndex = 5;
            BtnReports.Text = "Reports";
            BtnReports.TextAlign = ContentAlignment.MiddleLeft;
            BtnReports.UseVisualStyleBackColor = true;
            BtnReports.Click += BtnReports_Click;
            // 
            // btnLogs
            // 
            btnLogs.Cursor = Cursors.AppStarting;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.Image = Properties.Resources.logs;
            btnLogs.ImageAlign = ContentAlignment.MiddleRight;
            btnLogs.Location = new Point(55, 266);
            btnLogs.Margin = new Padding(0, 8, 0, 0);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(145, 39);
            btnLogs.TabIndex = 4;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += BtnLogs_Click;
            // 
            // btnSyn
            // 
            btnSyn.Cursor = Cursors.AppStarting;
            btnSyn.FlatAppearance.BorderSize = 0;
            btnSyn.FlatStyle = FlatStyle.Flat;
            btnSyn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSyn.Image = (Image)resources.GetObject("btnSyn.Image");
            btnSyn.ImageAlign = ContentAlignment.MiddleRight;
            btnSyn.Location = new Point(64, 215);
            btnSyn.Margin = new Padding(0, 8, 0, 0);
            btnSyn.Name = "btnSyn";
            btnSyn.Size = new Size(145, 39);
            btnSyn.TabIndex = 3;
            btnSyn.Text = "Syn";
            btnSyn.TextAlign = ContentAlignment.MiddleLeft;
            btnSyn.UseVisualStyleBackColor = true;
            btnSyn.Click += BtnSyn_Click;
            // 
            // btnProducts
            // 
            btnProducts.Cursor = Cursors.AppStarting;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleRight;
            btnProducts.Location = new Point(64, 62);
            btnProducts.Margin = new Padding(0, 12, 0, 0);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(145, 39);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += BtnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Cursor = Cursors.AppStarting;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleRight;
            btnOrders.Location = new Point(64, 113);
            btnOrders.Margin = new Padding(0, 12, 0, 0);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(145, 39);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += BtnOrders_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.AppStarting;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleRight;
            btnDashboard.Location = new Point(64, 7);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(145, 39);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += DashboardClicked;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(229, 93);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(619, 389);
            panelContent.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 504);
            Controls.Add(panelContent);
            Controls.Add(panelSider);
            Controls.Add(panelHeader);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panelHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpLeft.ResumeLayout(false);
            panelSider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

