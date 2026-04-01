namespace App.WindowApp.forms
{
    partial class ProductsForm
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
            panel1 = new Panel();
            panel4 = new Panel();
            tlpProductsForm = new TableLayoutPanel();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            textBoxName = new TextBox();
            comboBoxStatus = new ComboBox();
            comboBoxCategory = new ComboBox();
            textBoxId = new TextBox();
            labelName = new Label();
            labelPrice = new Label();
            labelStock = new Label();
            labelStatus = new Label();
            labelId = new Label();
            labelCategory = new Label();
            panelFooter = new Panel();
            subPanelFooter = new Panel();
            btnSave = new Button();
            button2 = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tlpProductsForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            panelFooter.SuspendLayout();
            subPanelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panelFooter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 353);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tlpProductsForm);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 266);
            panel4.TabIndex = 2;
            // 
            // tlpProductsForm
            // 
            tlpProductsForm.ColumnCount = 2;
            tlpProductsForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.56688F));
            tlpProductsForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.43312F));
            tlpProductsForm.Controls.Add(nudPrice, 1, 2);
            tlpProductsForm.Controls.Add(nudStock, 1, 3);
            tlpProductsForm.Controls.Add(textBoxName, 1, 0);
            tlpProductsForm.Controls.Add(comboBoxStatus, 1, 4);
            tlpProductsForm.Controls.Add(comboBoxCategory, 1, 1);
            tlpProductsForm.Controls.Add(textBoxId, 1, 5);
            tlpProductsForm.Controls.Add(labelName);
            tlpProductsForm.Controls.Add(labelPrice, 0, 2);
            tlpProductsForm.Controls.Add(labelStock, 0, 3);
            tlpProductsForm.Controls.Add(labelStatus, 0, 4);
            tlpProductsForm.Controls.Add(labelId, 0, 5);
            tlpProductsForm.Controls.Add(labelCategory, 0, 1);
            tlpProductsForm.Dock = DockStyle.Top;
            tlpProductsForm.Location = new Point(0, 0);
            tlpProductsForm.Margin = new Padding(4, 8, 4, 0);
            tlpProductsForm.Name = "tlpProductsForm";
            tlpProductsForm.Padding = new Padding(13, 11, 13, 11);
            tlpProductsForm.RowCount = 6;
            tlpProductsForm.RowStyles.Add(new RowStyle(SizeType.Percent, 8.806818F));
            tlpProductsForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10.511364F));
            tlpProductsForm.RowStyles.Add(new RowStyle(SizeType.Percent, 9.659091F));
            tlpProductsForm.RowStyles.Add(new RowStyle(SizeType.Percent, 11.931818F));
            tlpProductsForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.215909F));
            tlpProductsForm.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5909081F));
            tlpProductsForm.Size = new Size(500, 286);
            tlpProductsForm.TabIndex = 0;
            tlpProductsForm.Paint += tlpProductsForm_Paint;
            // 
            // nudPrice
            // 
            nudPrice.Dock = DockStyle.Bottom;
            nudPrice.Location = new Point(127, 63);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(357, 23);
            nudPrice.TabIndex = 0;
            // 
            // nudStock
            // 
            nudStock.Dock = DockStyle.Bottom;
            nudStock.Location = new Point(127, 92);
            nudStock.Margin = new Padding(3, 2, 3, 2);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(357, 23);
            nudStock.TabIndex = 1;
            nudStock.ValueChanged += nudStock_ValueChanged;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Bottom;
            textBoxName.Location = new Point(127, 13);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(357, 23);
            textBoxName.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Dock = DockStyle.Bottom;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(127, 124);
            comboBoxStatus.Margin = new Padding(3, 2, 3, 2);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(357, 23);
            comboBoxStatus.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Dock = DockStyle.Bottom;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(127, 36);
            comboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(357, 23);
            comboBoxCategory.TabIndex = 5;
            // 
            // textBoxId
            // 
            textBoxId.Dock = DockStyle.Fill;
            textBoxId.Location = new Point(127, 151);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(357, 23);
            textBoxId.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Location = new Point(13, 11);
            labelName.Margin = new Padding(0);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Location = new Point(13, 65);
            labelPrice.Margin = new Padding(0, 4, 0, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 9;
            labelPrice.Text = "Price";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.Transparent;
            labelStock.Location = new Point(13, 90);
            labelStock.Margin = new Padding(0, 4, 0, 0);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(36, 15);
            labelStock.TabIndex = 10;
            labelStock.Text = "Stock\r\n";
            labelStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Location = new Point(13, 121);
            labelStatus.Margin = new Padding(0, 4, 0, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 11;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.Transparent;
            labelId.Location = new Point(13, 153);
            labelId.Margin = new Padding(0, 4, 0, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 12;
            labelId.Text = "Id";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Location = new Point(13, 38);
            labelCategory.Margin = new Padding(0, 4, 0, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(55, 15);
            labelCategory.TabIndex = 8;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(subPanelFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 266);
            panelFooter.Margin = new Padding(3, 2, 3, 2);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(500, 87);
            panelFooter.TabIndex = 1;
            // 
            // subPanelFooter
            // 
            subPanelFooter.Controls.Add(btnSave);
            subPanelFooter.Controls.Add(button2);
            subPanelFooter.Controls.Add(btnCancel);
            subPanelFooter.Location = new Point(21, 14);
            subPanelFooter.Margin = new Padding(13, 11, 13, 11);
            subPanelFooter.Name = "subPanelFooter";
            subPanelFooter.Size = new Size(378, 56);
            subPanelFooter.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(286, 13);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(4, 0, 4, 4);
            btnSave.Size = new Size(77, 25);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Location = new Point(139, 20);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(7, 6);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(192, 13);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(4, 0, 4, 4);
            btnCancel.Size = new Size(88, 25);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 353);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tlpProductsForm.ResumeLayout(false);
            tlpProductsForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            panelFooter.ResumeLayout(false);
            subPanelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panelFooter;
        private Panel subPanelFooter;
        private Button btnSave;
        private Button button2;
        private Button btnCancel;
        private TableLayoutPanel tlpProductsForm;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private TextBox textBoxName;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxCategory;
        private TextBox textBoxId;
        private Label labelName;
        private Label labelPrice;
        private Label labelStock;
        private Label labelStatus;
        private Label labelId;
        private Label labelCategory;
    }
}