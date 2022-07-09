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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="admin" && textBox2.Text == "armagedon133")
            {
                
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                MessageBox.Show("Login Succesfull");
                

            }
           else
            {
                MessageBox.Show("Error: Please enter correct information");
            }
        }
    }
}
