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
        private Button btnIncoming;
        private Button btnOutgoing;
        private TextBox txtSearch;
        private GroupBox groupBoxStatistics;
        private Label lblTotalItems;
        private Label lblTotalProducts;
        private Label lblTotalValue;

        private void InitializeComponent()
        {
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnIncoming = new System.Windows.Forms.Button();
            this.btnOutgoing = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.ColumnHeadersHeight = 29;
            this.dataGridViewProducts.Location = new System.Drawing.Point(14, 13);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(887, 320);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 347);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(226, 398);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(349, 398);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 32);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnIncoming
            // 
            this.btnIncoming.Location = new System.Drawing.Point(381, 347);
            this.btnIncoming.Name = "btnIncoming";
            this.btnIncoming.Size = new System.Drawing.Size(158, 37);
            this.btnIncoming.TabIndex = 4;
            this.btnIncoming.Text = "Поступление (+)";
            this.btnIncoming.UseVisualStyleBackColor = true;
            // 
            // btnOutgoing
            // 
            this.btnOutgoing.Location = new System.Drawing.Point(545, 347);
            this.btnOutgoing.Name = "btnOutgoing";
            this.btnOutgoing.Size = new System.Drawing.Size(167, 37);
            this.btnOutgoing.TabIndex = 5;
            this.btnOutgoing.Text = "Списание (-)";
            this.btnOutgoing.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 400);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.lblTotalItems);
            this.groupBoxStatistics.Controls.Add(this.lblTotalProducts);
            this.groupBoxStatistics.Controls.Add(this.lblTotalValue);
            this.groupBoxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxStatistics.Location = new System.Drawing.Point(14, 443);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(887, 107);
            this.groupBoxStatistics.TabIndex = 9;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Статистика склада";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(11, 23);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(133, 18);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Всего единиц: 0";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Location = new System.Drawing.Point(11, 50);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(142, 18);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "Всего товаров: 0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(11, 77);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(206, 18);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "Общая стоимость: 0 руб.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 565);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnIncoming);
            this.Controls.Add(this.btnOutgoing);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBoxStatistics);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIM - Управление складом";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}