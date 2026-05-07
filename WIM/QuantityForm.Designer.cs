using System;
using System.Drawing;
using System.Windows.Forms;

namespace WIM
{
    partial class QuantityForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblOperation;
        private Label lblProductName;
        private TextBox txtQuantity;
        private Button btnOk;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOperation = new Label();
            this.lblProductName = new Label();
            this.txtQuantity = new TextBox();
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblOperation.Location = new Point(30, 25);
            this.lblOperation.Text = "Операция";

            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblProductName.Location = new Point(30, 55);
            this.lblProductName.Text = "Товар";

            this.txtQuantity.Font = new Font("Segoe UI", 14F);
            this.txtQuantity.Location = new Point(44, 95);
            this.txtQuantity.Size = new Size(225, 32);
            this.txtQuantity.TextAlign = HorizontalAlignment.Center;

            this.btnOk.Location = new Point(44, 150);
            this.btnOk.Size = new Size(100, 40);
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new EventHandler(this.btnOk_Click);

            this.btnCancel.Location = new Point(169, 150);
            this.btnCancel.Size = new Size(100, 40);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(314, 221);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblOperation);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuantityForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Изменение количества";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}