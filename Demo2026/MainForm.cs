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
            labelUser.Text=Form1.User.LastName+" "+Form1.User.FirstName.Substring(0,1)+"."
               +Form1.User.MiddleName.Substring(0,1)+".";
            db=new Demo11Context();
            UpdateForm();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Instance.Show();
        }
        private void UpdateForm()
        {
            panel1.Controls.Clear();
            list = db.Orders.ToList();
            int y = 0;
            foreach (Order order in list)
            {
                UserControlOrder uc = new UserControlOrder(order, this);
                uc.Top=y;
                panel1.Controls.Add(uc);
                y+=uc.Height;
            }
        }
    }
}
