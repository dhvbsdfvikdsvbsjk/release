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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (roli.rol == "директор            ")
            {
               
            }
            if (roli.rol == "сотрудник           ")
            {
                
            }
            if (roli.rol == "пациент             ")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meddbDataSet2.сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.meddbDataSet2.сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meddbDataSet.прием". При необходимости она может быть перемещена или удалена.
            this.приемTableAdapter.Fill(this.meddbDataSet.прием);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
    new System.Data.SqlClient.SqlConnection(@"Data Source=PK306NEW-5\SQL2019;Initial Catalog=meddb;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[прием] ([видУслуги],[датаПриема],[данныеОвраче],[стоимость],[диагноз])VALUES('" + comboBox3.Text + "','" + textBox2.Text + "','" + comboBox1.Text+ "','" + textBox4.Text + "','" + comboBox2.Text + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("запись добавлена в бд");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
   new System.Data.SqlClient.SqlConnection(@"Data Source=PK306NEW-5\SQL2019;Initial Catalog=meddb;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from [dbo].[прием] where [данныеОвраче] = '"+comboBox1.Text+"'";
            cmd.Connection = sqlConnection1;
            roli.res = comboBox2.Text;
            roli.cost = textBox4.Text;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("запись удалена из бд");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
            Hide();
        }
    }
}
