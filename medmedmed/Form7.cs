using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medmedmed
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            label5.Text = roli.cost;
            label6.Text = Convert.ToString(DateTime.Today);
            label7.Text = "кредитная карта";
            label8.Text = roli.res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
