using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WIM
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; }
        private bool _isEditMode;
        private int _editId;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            _isEditMode = true;
            _editId = product.Id;
            this.Text = "Редактирование товара";
            btnSave.Text = "Обновить";

            txtName.Text = product.Name;
            txtQuantity.Text = product.Quantity.ToString();
            txtPrice.Text = product.Price.ToString();
            txtCategory.Text = product.Category;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Введите корректное количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Введите корректную цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Введите категорию товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return;
            }

            if (_isEditMode)
            {
                Product = new Product
                {
                    Id = _editId,
                    Name = txtName.Text.Trim(),
                    Quantity = quantity,
                    Price = price,
                    Category = txtCategory.Text.Trim()
                };
            }
            else
            {
                Product = new Product
                {
                    Name = txtName.Text.Trim(),
                    Quantity = quantity,
                    Price = price,
                    Category = txtCategory.Text.Trim()
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}