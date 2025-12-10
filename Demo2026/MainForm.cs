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
    public partial class MainForm : Form
    {
        private List<Order> list;
        private Demo11Context db;
        public MainForm()
        {
            InitializeComponent();
            labelUser.Text = Form1.User.LastName + " " + Form1.User.FirstName.Substring(0, 1) + "."
               + Form1.User.MiddleName.Substring(0, 1) + ".";
            db = new Demo11Context();
            list = db.Orders.ToList();
            UpdateForm(list);
            if(Form1.User.Role=="Авторизированный клиент")
            {
                textBox1.Visible=false;
                label2.Visible=false;
                label1.Visible=false;
                comboBox1.Visible=false;
                button1.Visible=false;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Instance.Show();
        }
        public void UpdateForm(List<Order> list)
        {
            //обновление формы
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            panel1.Controls.Clear();
            int y = 0;
            foreach (Order order in list)
            {
                UserControlOrder uc = new UserControlOrder(order, this);
                uc.Top = y;
                panel1.Controls.Add(uc);
                y += uc.Height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //добавление элемента
            FormOrder formAdd = new FormOrder(new Order());
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                Order order = new Order();
                order.Articul = formAdd.textBoxArticul.Text;
                order.Name = formAdd.textBoxName.Text;
                order.UnitMeasure = formAdd.textBoxUM.Text;
                order.Price = decimal.Parse(formAdd.textBoxPrice.Text);
                order.Suplier = formAdd.textBoxSuplier.Text;
                order.Manufacture = formAdd.textBoxManufactor.Text;
                order.Category = formAdd.textBoxCategory.Text;
                order.Discount = int.Parse(formAdd.numericUpDown1.Value.ToString());
                order.Count = int.Parse(formAdd.textBoxCount.Text);
                order.Description = formAdd.textBoxDescription.Text;
                if (formAdd.FilePath != null)
                {
                    FileInfo file= new FileInfo(formAdd.FilePath);
                    file.CopyTo(Environment.CurrentDirectory +
                        @"\Photo\" + formAdd.FileName, true);
                    order.Photo = formAdd.FileName;
                }
                db.Orders.Add(order);
                db.SaveChanges();
                UpdateForm(db.Orders.ToList());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        list = db.Orders.OrderBy(p => p.Articul).ToList();
                        break;
                    case 1:
                        list = db.Orders.OrderBy(p => p.Name).ToList();
                        break;
                    case 2:
                        list = db.Orders.OrderBy(p => p.UnitMeasure).ToList();
                        break;
                    case 3:
                        list = db.Orders.OrderBy(p => p.Price).ToList();
                        break;
                    case 4:
                        list = db.Orders.OrderBy(p => p.Suplier).ToList();
                        break;
                    case 5:
                        list = db.Orders.OrderBy(p => p.Manufacture).ToList();
                        break;
                    case 6:
                        list = db.Orders.OrderBy(p => p.Category).ToList();
                        break;
                    case 7:
                        list = db.Orders.OrderBy(p => p.Discount).ToList();
                        break;
                    case 8:
                        list = db.Orders.OrderBy(p => p.Count).ToList();
                        break;
                }
                UpdateForm(list);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                list = db.Orders.Where(p => p.Name.StartsWith(textBox1.Text) ||
                                        p.Articul.StartsWith(textBox1.Text) ||
                                        p.UnitMeasure.StartsWith(textBox1.Text) ||
                                        p.Suplier.StartsWith(textBox1.Text) ||
                                        p.Manufacture.StartsWith(textBox1.Text) ||
                                        p.Category.StartsWith(textBox1.Text)).ToList();
                UpdateForm(list);
            }
            else
            {
                list = db.Orders.ToList();
                UpdateForm(list);
            }
        }
    }
}
