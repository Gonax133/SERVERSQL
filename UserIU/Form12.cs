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
    public partial class Form12 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P3BPN85;Initial Catalog=CPMS;Integrated Security=True");
        public Form12()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            sda = new SqlDataAdapter(@"SELECT * FROM Reviewer INNER JOIN Paper ON (Paper.AnalysisOfAlgorithms = Reviewer.AnalysisOfAlgorithms OR Paper.Applications = Reviewer.Applications OR Paper.Architecture = Reviewer.Architecture OR Paper.ArtificialIntelligence = Reviewer.ArtificialIntelligence OR Paper.ComputerEngineering = Reviewer.ComputerEngineering OR Paper.Curriculum = Reviewer.Curriculum OR Paper.DataStructures = Reviewer.DataStructures OR Paper.Databases = Reviewer.Databases OR Paper.DistanceLearning = Reviewer.DistancedLearning)  WHERE ReviewerID IN (SELECT ReviewerID FROM Reviewer WHERE( FirstName = '" + textBox2.Text + "' AND LastName = '" + textBox3.Text + "')) ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f7 = new Form4();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f7 = new Form6();
            f7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f7 = new Form13();
            f7.Show();
        }
    }
}
