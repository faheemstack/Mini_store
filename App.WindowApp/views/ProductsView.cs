using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.contracts;
using App.Core.utilities;
using App.WindowApp.forms;
using App.Core.models;


namespace App.WindowApp.views
{
    public partial class ProductsView : UserControl
    {
        IProductServices _service;
        BindingSource _dgvBindingSource = new BindingSource();



        private readonly IProductServices _services;

        public ProductsView(IProductServices _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvBindingSource;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void load(object sender, EventArgs e)
        {
            _service.GetAll();
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("~~ALL~~");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductsCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("~~ALL~~");
            cmbStatus.Items.AddRange(Enum.GetNames(typeof(ProductsStatusEnum)));
            cmbStatus.SelectedIndex = 0;


            if (_service == null)
                return;
            _service.GetAll();

            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ProductsForm proForm = new ProductsForm(ProductFormModeEnum.Add, null);
            proForm.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct =  _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm proForm = new ProductsForm(ProductFormModeEnum.Edit, selectedProduct);
            proForm.ShowDialog();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm proForm = new ProductsForm(ProductFormModeEnum.Edit, selectedProduct);
                proForm.ShowDialog();
            }
        }
    }
}
