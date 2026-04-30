using System.Drawing;
using System.Windows.Forms;

namespace WIM
{
    partial class ProductForm
    {
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtCategory;
        private Label lblName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblCategory;
        private Button btnSave;
        private Button btnCancel;

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtQuantity = new TextBox();
            this.txtPrice = new TextBox();
            this.txtCategory = new TextBox();
            this.lblName = new Label();
            this.lblQuantity = new Label();
            this.lblPrice = new Label();
            this.lblCategory = new Label();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new Font("Segoe UI", 10F);
            this.txtName.Location = new Point(130, 30);
            this.txtName.Size = new Size(250, 25);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new Font("Segoe UI", 10F);
            this.txtQuantity.Location = new Point(130, 70);
            this.txtQuantity.Size = new Size(250, 25);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new Font("Segoe UI", 10F);
            this.txtPrice.Location = new Point(130, 110);
            this.txtPrice.Size = new Size(250, 25);
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new Font("Segoe UI", 10F);
            this.txtCategory.Location = new Point(130, 150);
            this.txtCategory.Size = new Size(250, 25);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.lblName.Location = new Point(30, 33);
            this.lblName.Text = "Название:*";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.lblQuantity.Location = new Point(30, 73);
            this.lblQuantity.Text = "Количество:*";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.lblPrice.Location = new Point(30, 113);
            this.lblPrice.Text = "Цена:*";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold);
            this.lblCategory.Location = new Point(30, 153);
            this.lblCategory.Text = "Категория:*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.Transparent;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.Location = new Point(90, 210);
            this.btnSave.Size = new Size(120, 40);
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.Transparent;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Location = new Point(230, 210);
            this.btnCancel.Size = new Size(120, 40);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(414, 281);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}