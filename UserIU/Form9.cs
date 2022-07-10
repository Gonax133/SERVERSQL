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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f2 = new Form8();
            f2.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
            MessageBox.Show("Logout Succesfull");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
