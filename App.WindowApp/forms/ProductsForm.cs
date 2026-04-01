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
        public ProductsForm(ProductFormModeEnum mode, Product? p)
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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void nudStock_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
