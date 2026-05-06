using System.Drawing;
using System.Windows.Forms;

namespace WIM
{
    partial class MainForm
    {
        private DataGridView dataGridViewProducts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnRefresh;
        private TextBox txtSearch;
        private GroupBox groupBoxStatistics;
        private Label lblTotalItems;
        private Label lblTotalProducts;
        private Label lblTotalValue;

        private void InitializeComponent()
        {
            this.dataGridViewProducts = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSearch = new Button();
            this.btnRefresh = new Button();
            this.txtSearch = new TextBox();
            this.groupBoxStatistics = new GroupBox();
            this.lblTotalItems = new Label();
            this.lblTotalProducts = new Label();
            this.lblTotalValue = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();

            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dataGridViewProducts.Location = new Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new Size(776, 320);
            this.dataGridViewProducts.TabIndex = 0;

            this.btnAdd.Location = new Point(12, 345);
            this.btnAdd.Size = new Size(90, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;

            this.btnEdit.Location = new Point(108, 345);
            this.btnEdit.Size = new Size(90, 35);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;

            this.btnDelete.Location = new Point(204, 345);
            this.btnDelete.Size = new Size(90, 35);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;

            this.txtSearch.Location = new Point(12, 395);
            this.txtSearch.Size = new Size(180, 23);

            this.btnSearch.Location = new Point(198, 393);
            this.btnSearch.Size = new Size(80, 30);
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;

            this.btnRefresh.Location = new Point(284, 393);
            this.btnRefresh.Size = new Size(80, 30);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;

            this.groupBoxStatistics.Text = "Статистика склада";
            this.groupBoxStatistics.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.groupBoxStatistics.Location = new Point(12, 435);
            this.groupBoxStatistics.Size = new Size(776, 100);

            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new Point(10, 22);
            this.lblTotalItems.Text = "Всего единиц: 0";

            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Location = new Point(10, 47);
            this.lblTotalProducts.Text = "Всего товаров: 0";

            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new Point(10, 72);
            this.lblTotalValue.Text = "Общая стоимость: 0 руб.";

            this.groupBoxStatistics.Controls.Add(this.lblTotalItems);
            this.groupBoxStatistics.Controls.Add(this.lblTotalProducts);
            this.groupBoxStatistics.Controls.Add(this.lblTotalValue);

            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBoxStatistics);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 550);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "WIM - Управление складом";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}