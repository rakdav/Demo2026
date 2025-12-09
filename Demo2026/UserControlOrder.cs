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
            label1.Text = order.Discount.ToString();
            label2.Text = order.Category + " | " + order.Name;
            label3.Text = "Описание товара:" + order.Description;
            label4.Text = "Производитель:" + order.Manufacture;
            label5.Text = "Поставщик:" + order.Suplier;
            label6.Text = "Цена:" + order.Price;
            label7.Text = "Единица измерения:" + order.UnitMeasure;
            label8.Text = "Количество на складе:" + order.Count;
        }
    }
}
