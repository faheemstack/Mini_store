namespace WindowsLab.views
{
    partial class ProductsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProductHeader = new System.Windows.Forms.Panel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            this.view = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlProductMid = new System.Windows.Forms.Panel();
            this.tblFilter = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProductsBottom = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldtock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlProductHeader.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnlProductMid.SuspendLayout();
            this.tblFilter.SuspendLayout();
            this.pnlProductsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlProductHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlProductMid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlProductsBottom, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlProductHeader
            // 
            this.pnlProductHeader.BackColor = System.Drawing.Color.White;
            this.pnlProductHeader.Controls.Add(this.panelProducts);
            this.pnlProductHeader.Controls.Add(this.tabControl1);
            this.pnlProductHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlProductHeader.Name = "pnlProductHeader";
            this.pnlProductHeader.Size = new System.Drawing.Size(754, 50);
            this.pnlProductHeader.TabIndex = 0;
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.toolStrip);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(0, 0);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(754, 50);
            this.panelProducts.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.Edit,
            this.view,
            this.delete,
            this.Refresh});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(10);
            this.toolStrip.Size = new System.Drawing.Size(754, 50);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // add
            // 
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(61, 27);
            this.add.Text = "Add";
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(59, 27);
            this.Edit.Text = "Edit";
            // 
            // view
            // 
            this.view.Image = ((System.Drawing.Image)(resources.GetObject("view.Image")));
            this.view.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(65, 27);
            this.view.Text = "View";
            // 
            // delete
            // 
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 27);
            this.delete.Text = "Delete";
            // 
            // Refresh
            // 
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(82, 27);
            this.Refresh.Text = "Refresh";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(308, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlProductMid
            // 
            this.pnlProductMid.BackColor = System.Drawing.Color.White;
            this.pnlProductMid.Controls.Add(this.tblFilter);
            this.pnlProductMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductMid.Location = new System.Drawing.Point(3, 59);
            this.pnlProductMid.Name = "pnlProductMid";
            this.pnlProductMid.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlProductMid.Size = new System.Drawing.Size(754, 78);
            this.pnlProductMid.TabIndex = 1;
            // 
            // tblFilter
            // 
            this.tblFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFilter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblFilter.ColumnCount = 3;
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilter.Controls.Add(this.comboBox1, 1, 1);
            this.tblFilter.Controls.Add(this.comboBox2, 2, 1);
            this.tblFilter.Controls.Add(this.textBox1, 0, 1);
            this.tblFilter.Controls.Add(this.label1, 0, 0);
            this.tblFilter.Controls.Add(this.label2, 1, 0);
            this.tblFilter.Controls.Add(this.label3, 2, 0);
            this.tblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilter.Location = new System.Drawing.Point(12, 10);
            this.tblFilter.Name = "tblFilter";
            this.tblFilter.RowCount = 2;
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilter.Size = new System.Drawing.Size(730, 58);
            this.tblFilter.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(513, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(4, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // pnlProductsBottom
            // 
            this.pnlProductsBottom.BackColor = System.Drawing.Color.White;
            this.pnlProductsBottom.Controls.Add(this.hScrollBar1);
            this.pnlProductsBottom.Controls.Add(this.dataGridViewProducts);
            this.pnlProductsBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsBottom.Location = new System.Drawing.Point(3, 143);
            this.pnlProductsBottom.Name = "pnlProductsBottom";
            this.pnlProductsBottom.Padding = new System.Windows.Forms.Padding(12);
            this.pnlProductsBottom.Size = new System.Drawing.Size(754, 280);
            this.pnlProductsBottom.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(327, 99);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.coldtock,
            this.colStatus});
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(730, 256);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Cateory";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // coldtock
            // 
            this.coldtock.HeaderText = "Stock";
            this.coldtock.MinimumWidth = 6;
            this.coldtock.Name = "coldtock";
            this.coldtock.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(760, 426);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlProductHeader.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pnlProductMid.ResumeLayout(false);
            this.tblFilter.ResumeLayout(false);
            this.tblFilter.PerformLayout();
            this.pnlProductsBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlProductHeader;
        private System.Windows.Forms.Panel pnlProductMid;
        private System.Windows.Forms.Panel pnlProductsBottom;
        private System.Windows.Forms.TableLayoutPanel tblFilter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton Edit;
        private System.Windows.Forms.ToolStripButton view;
        private System.Windows.Forms.ToolStripButton delete;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldtock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
