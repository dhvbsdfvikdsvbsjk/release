using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 
namespace medmedmed
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PK306NEW-5\SQL2019;Initial Catalog=meddb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "use meddb select пользователь from[авторизация] where логин = '" + textBox1.Text + "' and пароль = '"+textBox2.Text+"' ";
                cmd.CommandText = query;
                cmd.Connection = con;
                var result = cmd.ExecuteScalar().ToString();
                MessageBox.Show(result);
                roli.rol = result;
                Form2 f = new Form2();
                f.Show();
                Hide();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
