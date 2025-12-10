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
    public partial class FormOrder : Form
    {
        public string FilePath;
        public string FileName;
        public FormOrder(Order order)
        {
            InitializeComponent();
            textBoxArticul.Text = order.Articul;
            textBoxCategory.Text = order.Category;
            textBoxCount.Text = order.Count.ToString();
            textBoxDescription.Text = order.Description;
            textBoxManufactor.Text = order.Manufacture;
            textBoxName.Text = order.Name;
            textBoxPrice.Text = order.Price.ToString();
            textBoxSuplier.Text = order.Suplier;
            numericUpDown1.Value = order.Discount;
            textBoxUM.Text = order.UnitMeasure;
            if (order.Photo != "" && order.Photo != null)
            {
                pictureBox1.Image=Image.FromFile(Environment.CurrentDirectory +
                        @"\Photo\"+order.Photo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                FilePath = openFileDialog1.FileName;
                FileName = openFileDialog1.SafeFileName;
            }
        }
    }
}
