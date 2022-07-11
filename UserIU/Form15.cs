using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UserIU
{
    public partial class Form15 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P3BPN85;Initial Catalog=CPMS;Integrated Security=True");
        public Form15()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM[Author]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f4 = new Form2();
            f4.Show();
        }
    }
}
