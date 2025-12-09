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
        public MainForm()
        {
            InitializeComponent();
            labelUser.Text=Form1.User.LastName+" "+Form1.User.FirstName.Substring(0,1)+"."
               +Form1.User.MiddleName.Substring(0,1)+".";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Instance.Show();
        }
    }
}
