using System.Drawing;
using System.Windows.Forms;

namespace WIM
{
    partial class MainForm
    {
        private DataGridView dataGridViewProducts;
        private Button btnAdd;
        private Button btnEdit;

        private void InitializeComponent()
        {
            this.dataGridViewProducts = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dataGridViewProducts.Location = new Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new Size(776, 400);
            this.dataGridViewProducts.TabIndex = 0;

            this.btnAdd.Location = new Point(12, 425);
            this.btnAdd.Size = new Size(100, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;

            this.btnEdit.Location = new Point(118, 425);
            this.btnEdit.Size = new Size(100, 35);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;

            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 480);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "WIM - Управление складом";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}