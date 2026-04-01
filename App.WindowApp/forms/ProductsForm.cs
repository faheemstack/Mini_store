using App.Core.contracts;
using App.Core.models;
using App.Core.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowApp.forms
{
    public partial class ProductsForm : Form
    {
        ProductFormModeEnum _mode;
        Product _product;
        IProductServices _service;
        public ProductsForm(ProductFormModeEnum mode, Product? p, IProductServices service)
        {

            InitializeComponent();


            nudPrice.Maximum = decimal.MaxValue;
            nudStock.Maximum = Int32.MaxValue;

            comboBoxCategory.Items.Clear();

            comboBoxCategory.DataSource = Enum.GetValues(typeof(ProductsCategoryEnum));
            comboBoxCategory.SelectedIndex = 0;

            comboBoxStatus.Items.Clear();

            comboBoxStatus.DataSource = Enum.GetValues(typeof(ProductsStatusEnum));
            comboBoxStatus.SelectedIndex = 0;


            _mode = mode;
            _product = p;
            _service = service;
            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                btnSave.Text = "Update";
                textBoxName.Text = p.Name;
                textBoxId.Text = p.Id;
                comboBoxCategory.SelectedItem = p.Category;
                nudPrice.Value = p.Price;
                nudStock.Value = p.Stock;
            }



        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void tlpProductsForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = textBoxName.Text;
                newProduct.Category = (ProductsCategoryEnum)comboBoxCategory.SelectedItem;
                newProduct.Status = (ProductsStatusEnum)comboBoxStatus.SelectedItem;
                newProduct.Price = nudPrice.Value;
                newProduct.Stock = (int)nudStock.Value;

                //_product = _service.Add(newProduct);
                //textBoxId.Text = _product.Id;

                Product temp = _service.Add(newProduct);
                textBoxId.Text = temp?.Id ?? "";



            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = textBoxName.Text;
                _product.Category = (ProductsCategoryEnum)comboBoxCategory.SelectedItem;
                _product.Status = (ProductsStatusEnum)comboBoxStatus.SelectedItem;
                _product.Price = nudPrice.Value;
                _product.Stock = (int)nudStock.Value;
                bool isUpdated = _service.Update(_product);


            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudStock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void subPanelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
