using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WIM
{
    public partial class MainForm : Form
    {
        private List<Product> _products = new List<Product>();

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            _products = LocalDb.GetProducts();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = _products;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewProducts.Columns.Contains("Id"))
                dataGridViewProducts.Columns["Id"].HeaderText = "ID";
            if (dataGridViewProducts.Columns.Contains("Name"))
                dataGridViewProducts.Columns["Name"].HeaderText = "Наименование";
            if (dataGridViewProducts.Columns.Contains("Quantity"))
                dataGridViewProducts.Columns["Quantity"].HeaderText = "Количество";
            if (dataGridViewProducts.Columns.Contains("Price"))
                dataGridViewProducts.Columns["Price"].HeaderText = "Цена (руб)";
            if (dataGridViewProducts.Columns.Contains("Category"))
                dataGridViewProducts.Columns["Category"].HeaderText = "Категория";

            dataGridViewProducts.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK && form.Product != null)
            {
                LocalDb.InsertProduct(form.Product);
                LoadProducts();
                MessageBox.Show("Товар успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для редактирования", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
            var form = new ProductForm(product);

            if (form.ShowDialog() == DialogResult.OK && form.Product != null)
            {
                LocalDb.UpdateProduct(form.Product);
                LoadProducts();
                MessageBox.Show("Товар успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}