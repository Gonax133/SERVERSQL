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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(""); 
        List<review> reviews = new List<review>();
        public Form6()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            if (comboBox1.Text == "Excellent")
            {
             x = 5.0;
            }

            if (comboBox1.Text == "Good")
            {
                x = 4.0;
            }
            if (comboBox1.Text == "Average")
            {
                x = 3.0;
            }

            if (comboBox1.Text == "Fair")
            {
                x = 2.0;
            }
            if (comboBox1.Text == "Poor")
            {
                x = 1.0;
            }

            if (comboBox2.Text == "Excellent")
            {
                y = 5.0;
            }

            if (comboBox2.Text == "Good")
            {
                y = 4.0;
            }
            if (comboBox2.Text == "Average")
            {
                y = 3.0;
            }

            if (comboBox2.Text == "Fair")
            {
                y = 2.0;
            }
            if (comboBox2.Text == "Poor")
            {
                y = 1.0;
            }
            DataInsert db = new DataInsert();
            
            reviews = db.GetReviews(textBox1.Text, textBox3.Text, textBox4.Text, x, y);

        }
    }
}
