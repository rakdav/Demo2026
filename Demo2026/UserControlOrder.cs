using Demo2026.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Demo2026
{
    public partial class UserControlOrder : UserControl
    {
        private Order order;
        private MainForm mainForm;
        public UserControlOrder(Order _order, MainForm _form)
        {
            InitializeComponent();
            this.order = _order;
            this.mainForm = _form;
            try
            {
                if (order.Discount > 15) this.BackColor = Color.Green;
                label1.Text = order.Discount.ToString();
                label2.Text = order.Category + " | " + order.Name;
                label3.Text = "Описание товара:" + order.Description;
                label4.Text = "Производитель:" + order.Manufacture;
                label5.Text = "Поставщик:" + order.Suplier;
                if (order.Discount > 0)
                {
                    label6.Font = new Font(new FontFamily("Times New Roman"), 9, FontStyle.Strikeout);
                    label6.ForeColor = Color.Red;
                }
                label6.Text = "Цена:" + order.Price;
                if (order.Discount > 0)
                {
                    label9.Visible = true;
                    decimal price = (decimal)(1 - (order.Discount / 100.0)) * order.Price;
                    label9.Text = price.ToString("F2");
                }
                label7.Text = "Единица измерения:" + order.UnitMeasure;
                label8.Text = "Количество на складе:" + order.Count;
                if (order.Photo != "" && order.Photo != null)
                {
                    pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory +
                        @"\Photo\" + order.Photo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы хотите удалить элемент {order.Name}", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (Demo11Context db = new Demo11Context())
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                    mainForm.UpdateForm(db.Orders.ToList());
                }
            }
        }

        private void UserControlOrder_DoubleClick(object sender, EventArgs e)
        {
            FormOrder form = new FormOrder(order);
            if (form.ShowDialog() == DialogResult.OK)
            {
                order.UnitMeasure = form.textBoxUM.Text;
                order.Manufacture = form.textBoxManufactor.Text;
                order.Category = form.textBoxCategory.Text;
                order.Price = decimal.Parse(form.textBoxPrice.Text);
                order.Count = int.Parse(form.textBoxCount.Text);
                order.Suplier = form.textBoxSuplier.Text;
                order.Description = form.textBoxDescription.Text;
                order.Discount = int.Parse(form.numericUpDown1.Value.ToString());
                order.Name = form.textBoxName.Text;
                if (form.FilePath != null)
                {
                    FileInfo file = new FileInfo(form.FilePath);
                    file.CopyTo(Environment.CurrentDirectory +
                        @"\Photo\" + form.FileName, true);
                    order.Photo = form.FileName;
                }
                using (Demo11Context db = new Demo11Context())
                {
                    db.Orders.Update(order);
                    db.SaveChanges();
                    mainForm.UpdateForm(db.Orders.ToList());
                }
            }
        }
    }
}
