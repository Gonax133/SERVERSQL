using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserIU
{
    public partial class Form6 : Form
    {
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
            DataInsert db = new DataInsert();
            reviews = db.GetReviews(textBox1.Text, textBox3.Text, textBox4.Text, comboBox1.Text, comboBox2.Text);

        }
    }
}
