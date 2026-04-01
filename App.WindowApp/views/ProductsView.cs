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
            var categories = new List<object> { "~~ALL" };
            categories.AddRange(Enum.GetValues(typeof(ProductsCategoryEnum)));
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            var status = new List<object> { "~~ALL" };
            status.AddRange(Enum.GetValues(typeof(ProductsCategoryEnum)));
            cmbStatus.DataSource = status;
            cmbStatus.SelectedIndex = 0;


            if (_service == null)
                return;
            //_service.GetAll();

            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ProductsForm proForm = new ProductsForm(ProductFormModeEnum.Add, null, _service);
            proForm.ShowDialog();
            refreshGrid();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm proForm = new ProductsForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                proForm.ShowDialog();
                refreshGrid();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm proForm = new ProductsForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                proForm.ShowDialog();
            }
        }
        private void refreshGrid()
        {
            string searchText = textBoxSearch.Text;

            ProductsCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedItem != null) {
                if (cmbCategory.SelectedItem.ToString().Equals("~~ALL~~")){

                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductsCategoryEnum)cmbCategory.SelectedItem;
                }
            }

            ProductsStatusEnum? selectedStatus = null;
            if (cmbStatus.SelectedItem != null)
            {
                if (cmbStatus.SelectedItem.ToString().Equals("~~ALL~~"))
                {

                    selectedStatus = null;
                }
                else
                {
                    selectedStatus = (ProductsStatusEnum)cmbStatus.SelectedItem;
                }
            }

            _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            refreshGrid();

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGrid();

        }
    }
}
