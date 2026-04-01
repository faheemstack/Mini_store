namespace App.WindowApp.views
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlProductHeader = new Panel();
            panelProducts = new Panel();
            toolStrip = new ToolStrip();
            add = new ToolStripButton();
            Edit = new ToolStripButton();
            view = new ToolStripButton();
            delete = new ToolStripButton();
            Refresh = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pnlProductMid = new Panel();
            tblFilter = new TableLayoutPanel();
            cmbCategory = new ComboBox();
            cmbStatus = new ComboBox();
            textBox1 = new TextBox();
            search = new Label();
            StockStatus = new Label();
            Category = new Label();
            pnlProductsBottom = new Panel();
            hScrollBar1 = new HScrollBar();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            coldtock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            pnlProductHeader.SuspendLayout();
            panelProducts.SuspendLayout();
            toolStrip.SuspendLayout();
            tabControl1.SuspendLayout();
            pnlProductMid.SuspendLayout();
            tblFilter.SuspendLayout();
            pnlProductsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlProductHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlProductMid, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlProductsBottom, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(665, 399);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlProductHeader
            // 
            pnlProductHeader.BackColor = Color.White;
            pnlProductHeader.Controls.Add(panelProducts);
            pnlProductHeader.Controls.Add(tabControl1);
            pnlProductHeader.Dock = DockStyle.Fill;
            pnlProductHeader.Location = new Point(3, 3);
            pnlProductHeader.Name = "pnlProductHeader";
            pnlProductHeader.Size = new Size(659, 46);
            pnlProductHeader.TabIndex = 0;
            // 
            // panelProducts
            // 
            panelProducts.Controls.Add(toolStrip);
            panelProducts.Dock = DockStyle.Fill;
            panelProducts.Location = new Point(0, 0);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(659, 46);
            panelProducts.TabIndex = 3;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { add, Edit, view, delete, Refresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(9);
            toolStrip.Size = new Size(659, 46);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip1";
            // 
            // add
            // 
            add.Image = (Image)resources.GetObject("add.Image");
            add.ImageAlign = ContentAlignment.BottomCenter;
            add.ImageTransparentColor = Color.Magenta;
            add.Name = "add";
            add.Size = new Size(53, 25);
            add.Text = "Add";
            add.Click += add_Click;
            // 
            // Edit
            // 
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageTransparentColor = Color.Magenta;
            Edit.Name = "Edit";
            Edit.Size = new Size(51, 25);
            Edit.Text = "Edit";
            Edit.Click += Edit_Click;
            // 
            // view
            // 
            view.Image = (Image)resources.GetObject("view.Image");
            view.ImageTransparentColor = Color.Magenta;
            view.Name = "view";
            view.Size = new Size(56, 25);
            view.Text = "View";
            view.Click += view_Click;
            // 
            // delete
            // 
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.ImageTransparentColor = Color.Magenta;
            delete.Name = "delete";
            delete.Size = new Size(64, 25);
            delete.Text = "Delete";
            // 
            // Refresh
            // 
            Refresh.Image = (Image)resources.GetObject("Refresh.Image");
            Refresh.ImageTransparentColor = Color.Magenta;
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(70, 25);
            Refresh.Text = "Refresh";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(270, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(175, 94);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(167, 66);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(167, 66);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlProductMid
            // 
            pnlProductMid.BackColor = Color.White;
            pnlProductMid.Controls.Add(tblFilter);
            pnlProductMid.Dock = DockStyle.Fill;
            pnlProductMid.Location = new Point(3, 55);
            pnlProductMid.Name = "pnlProductMid";
            pnlProductMid.Padding = new Padding(10, 9, 10, 9);
            pnlProductMid.Size = new Size(659, 73);
            pnlProductMid.TabIndex = 1;
            // 
            // tblFilter
            // 
            tblFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilter.ColumnCount = 3;
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.Controls.Add(cmbCategory, 1, 1);
            tblFilter.Controls.Add(cmbStatus, 2, 1);
            tblFilter.Controls.Add(textBox1, 0, 1);
            tblFilter.Controls.Add(search, 0, 0);
            tblFilter.Controls.Add(StockStatus, 2, 0);
            tblFilter.Controls.Add(Category, 1, 0);
            tblFilter.Dock = DockStyle.Fill;
            tblFilter.Location = new Point(10, 9);
            tblFilter.Name = "tblFilter";
            tblFilter.RowCount = 2;
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.Size = new Size(639, 55);
            tblFilter.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(259, 31);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(184, 23);
            cmbCategory.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(450, 31);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(185, 23);
            cmbStatus.TabIndex = 1;
            cmbStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(4, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 2;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Location = new Point(4, 1);
            search.Name = "search";
            search.Padding = new Padding(5);
            search.Size = new Size(52, 25);
            search.TabIndex = 3;
            search.Text = "Search";
            search.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StockStatus
            // 
            StockStatus.AutoSize = true;
            StockStatus.Location = new Point(450, 1);
            StockStatus.Name = "StockStatus";
            StockStatus.Padding = new Padding(5);
            StockStatus.Size = new Size(81, 25);
            StockStatus.TabIndex = 5;
            StockStatus.Text = "Stock Status";
            StockStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(259, 1);
            Category.Name = "Category";
            Category.Padding = new Padding(5);
            Category.Size = new Size(65, 25);
            Category.TabIndex = 4;
            Category.Text = "Category";
            Category.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlProductsBottom
            // 
            pnlProductsBottom.BackColor = Color.White;
            pnlProductsBottom.Controls.Add(hScrollBar1);
            pnlProductsBottom.Controls.Add(dgvProducts);
            pnlProductsBottom.Dock = DockStyle.Fill;
            pnlProductsBottom.Location = new Point(3, 134);
            pnlProductsBottom.Name = "pnlProductsBottom";
            pnlProductsBottom.Padding = new Padding(10, 11, 10, 11);
            pnlProductsBottom.Size = new Size(659, 262);
            pnlProductsBottom.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(286, 93);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(7, 8);
            hScrollBar1.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, coldtock, colStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(10, 11);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 24;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(639, 240);
            dgvProducts.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Cateory";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // coldtock
            // 
            coldtock.DataPropertyName = "Stock";
            coldtock.HeaderText = "Stock";
            coldtock.MinimumWidth = 6;
            coldtock.Name = "coldtock";
            coldtock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ProductsView";
            Size = new Size(665, 399);
            Load += ProductsView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnlProductHeader.ResumeLayout(false);
            panelProducts.ResumeLayout(false);
            panelProducts.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tabControl1.ResumeLayout(false);
            pnlProductMid.ResumeLayout(false);
            tblFilter.ResumeLayout(false);
            tblFilter.PerformLayout();
            pnlProductsBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label StockStatus;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn coldtock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
