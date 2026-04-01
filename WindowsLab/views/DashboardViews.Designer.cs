namespace WindowsLab.views
{
    partial class DashboardViews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "notbook",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("water");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("bagPack");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("HDMI");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("headpin");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "MS_10",
            "Maryam",
            "20,471",
            "Pending",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("MS_10");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("MS_10");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("MS_10");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("MS_10");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("MS_10");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("MS_10");
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.tblkpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrderValue = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlRevenne = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.DashBoardCenter = new System.Windows.Forms.Panel();
            this.panelLowStocks = new System.Windows.Forms.Panel();
            this.LowStocks = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colProducts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStocks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRecantOrder = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbl.SuspendLayout();
            this.tblkpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenne.SuspendLayout();
            this.DashBoardCenter.SuspendLayout();
            this.panelLowStocks.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRecantOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl
            // 
            this.tbl.ColumnCount = 1;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.Controls.Add(this.tblkpi, 0, 0);
            this.tbl.Controls.Add(this.DashBoardCenter, 0, 1);
            this.tbl.Controls.Add(this.panel2, 0, 2);
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(0, 0);
            this.tbl.Name = "tbl";
            this.tbl.Padding = new System.Windows.Forms.Padding(16);
            this.tbl.RowCount = 3;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.Size = new System.Drawing.Size(934, 539);
            this.tbl.TabIndex = 0;
            // 
            // tblkpi
            // 
            this.tblkpi.ColumnCount = 3;
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblkpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblkpi.Controls.Add(this.pnlSales, 0, 0);
            this.tblkpi.Controls.Add(this.pnlOrders, 1, 0);
            this.tblkpi.Controls.Add(this.pnlRevenne, 2, 0);
            this.tblkpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblkpi.Location = new System.Drawing.Point(19, 19);
            this.tblkpi.Name = "tblkpi";
            this.tblkpi.RowCount = 1;
            this.tblkpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblkpi.Size = new System.Drawing.Size(896, 114);
            this.tblkpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesValue);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(292, 108);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Location = new System.Drawing.Point(186, 40);
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.Size = new System.Drawing.Size(28, 16);
            this.lblSalesValue.TabIndex = 1;
            this.lblSalesValue.Text = "163";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(34, 40);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(42, 16);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderValue);
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.Location = new System.Drawing.Point(301, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(292, 108);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrderValue
            // 
            this.lblOrderValue.AutoSize = true;
            this.lblOrderValue.Location = new System.Drawing.Point(206, 40);
            this.lblOrderValue.Name = "lblOrderValue";
            this.lblOrderValue.Size = new System.Drawing.Size(21, 16);
            this.lblOrderValue.TabIndex = 3;
            this.lblOrderValue.Text = "33";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Location = new System.Drawing.Point(51, 40);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(48, 16);
            this.lblOrderT.TabIndex = 2;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlRevenne
            // 
            this.pnlRevenne.BackColor = System.Drawing.Color.White;
            this.pnlRevenne.Controls.Add(this.lblRevenueV);
            this.pnlRevenne.Controls.Add(this.lblRevenueT);
            this.pnlRevenne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevenne.Location = new System.Drawing.Point(599, 3);
            this.pnlRevenne.Name = "pnlRevenne";
            this.pnlRevenne.Size = new System.Drawing.Size(294, 108);
            this.pnlRevenne.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRevenueV.Location = new System.Drawing.Point(200, 40);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(57, 17);
            this.lblRevenueV.TabIndex = 5;
            this.lblRevenueV.Text = "37356/-";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(31, 40);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(62, 16);
            this.lblRevenueT.TabIndex = 4;
            this.lblRevenueT.Text = "Revenue";
            // 
            // DashBoardCenter
            // 
            this.DashBoardCenter.BackColor = System.Drawing.Color.White;
            this.DashBoardCenter.Controls.Add(this.panelLowStocks);
            this.DashBoardCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardCenter.Location = new System.Drawing.Point(19, 139);
            this.DashBoardCenter.Name = "DashBoardCenter";
            this.DashBoardCenter.Size = new System.Drawing.Size(896, 187);
            this.DashBoardCenter.TabIndex = 1;
            // 
            // panelLowStocks
            // 
            this.panelLowStocks.Controls.Add(this.LowStocks);
            this.panelLowStocks.Controls.Add(this.listView1);
            this.panelLowStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLowStocks.Location = new System.Drawing.Point(0, 0);
            this.panelLowStocks.Name = "panelLowStocks";
            this.panelLowStocks.Size = new System.Drawing.Size(896, 187);
            this.panelLowStocks.TabIndex = 2;
            this.panelLowStocks.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LowStocks
            // 
            this.LowStocks.AutoSize = true;
            this.LowStocks.Location = new System.Drawing.Point(11, 20);
            this.LowStocks.Name = "LowStocks";
            this.LowStocks.Size = new System.Drawing.Size(68, 16);
            this.LowStocks.TabIndex = 0;
            this.LowStocks.Text = "Low Stock";
            this.LowStocks.Click += new System.EventHandler(this.LowStocks_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProducts,
            this.colStocks});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(0, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(893, 148);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colProducts
            // 
            this.colProducts.Text = "Products";
            // 
            // colStocks
            // 
            this.colStocks.Text = "Stocks";
            this.colStocks.Width = 760;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelRecantOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(19, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 188);
            this.panel2.TabIndex = 2;
            // 
            // panelRecantOrder
            // 
            this.panelRecantOrder.Controls.Add(this.listView2);
            this.panelRecantOrder.Controls.Add(this.label2);
            this.panelRecantOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecantOrder.Location = new System.Drawing.Point(0, 0);
            this.panelRecantOrder.Name = "panelRecantOrder";
            this.panelRecantOrder.Size = new System.Drawing.Size(896, 188);
            this.panelRecantOrder.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrder,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.listView2.HideSelection = false;
            listViewItem12.Checked = true;
            listViewItem12.StateImageIndex = 1;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView2.Location = new System.Drawing.Point(0, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(896, 156);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // colOrder
            // 
            this.colOrder.Text = "oreders";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "customer";
            // 
            // colTotal
            // 
            this.colTotal.Text = "total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recent Orders";
            // 
            // DashboardViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl);
            this.Name = "DashboardViews";
            this.Size = new System.Drawing.Size(934, 539);
            this.tbl.ResumeLayout(false);
            this.tblkpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenne.ResumeLayout(false);
            this.pnlRevenne.PerformLayout();
            this.DashBoardCenter.ResumeLayout(false);
            this.panelLowStocks.ResumeLayout(false);
            this.panelLowStocks.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelRecantOrder.ResumeLayout(false);
            this.panelRecantOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl;
        private System.Windows.Forms.TableLayoutPanel tblkpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenne;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblOrderValue;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel DashBoardCenter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colProducts;
        private System.Windows.Forms.ColumnHeader colStocks;
        private System.Windows.Forms.Label LowStocks;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colOrder;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Panel panelLowStocks;
        private System.Windows.Forms.Panel panelRecantOrder;
    }
}
