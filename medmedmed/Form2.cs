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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            if (roli.rol == "директор            ")
            {
              
            }
            if (roli.rol == "сотрудник           ")
            {
                button3.Enabled = false;
            }
            if (roli.rol == "пациент             ")
            {
               
                button2.Enabled = false;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = roli.rol;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roli.rol == "пациент             ")
            {
                Form6 f = new Form6();
                f.Show();
                Hide();
            }
            else if (roli.rol == "директор            ")
            {
                Form3 f = new Form3();
                f.Show();
                Hide();
            }
            else if (roli.rol == "сотрудник           ")
            {
                Form3 f = new Form3();
                f.Show();
                Hide();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            Hide();
        }
    }
}
