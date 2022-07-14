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
    public partial class Form11 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P3BPN85;Initial Catalog=CPMS;Integrated Security=True");
        
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
        }
        private bool String_verify(string str)
        {
            foreach (char MMM in str)
            {
                if ((MMM >= 'a' && MMM <= 'z') || (MMM >= 'A' && MMM <= 'Z'))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("SQL injection is not permitted");
                    Close();
                }
            }

            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int f = 0;

            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;

            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;

            int xx = 0;
            int yy = 0;
            int zz = 0;
            int aa = 0;
            int bb = 0;
            int cc = 0;
            int dd = 0;
            int ff = 0;

            int gg = 0;
            int hh = 0;


            String_verify(textBox1.Text);
            String_verify(textBox2.Text);
            String_verify(textBox3.Text);
            String_verify(textBox5.Text);
            String_verify(textBox6.Text);
            String_verify(textBox8.Text);
            String_verify(textBox10.Text);
            String_verify(textBox8.Text);
            String_verify(comboBox1.Text);
            String_verify(textBox11.Text);
            String_verify(textBox7.Text);
            String_verify(textBox4.Text);
            String_verify(textBox13.Text);
            String_verify(textBox20.Text);

            if (checkBox1.Checked == true)
            {
                x = 1;
            }
            if (checkBox2.Checked == true)
            {
                y = 1;
            }
            if (checkBox3.Checked == true)
            {
                z = 1;
            }
            if (checkBox4.Checked == true)
            {
                a = 1;
            }
            if (checkBox5.Checked == true)
            {
                b = 1;
            }
            if (checkBox6.Checked == true)
            {
                c = 1;
            }
            if (checkBox7.Checked == true)
            {
                d = 1;
            }
            if (checkBox8.Checked == true)
            {
                f = 1;
            }
            if (checkBox9.Checked == true)
            {
                g = 1;
            }
            if (checkBox10.Checked == true)
            {
                h = 1;
            }
            if (checkBox11.Checked == true)
            {
                i = 1;
            }
            if (checkBox12.Checked == true)
            {
                j = 1;
            }
            if (checkBox13.Checked == true)
            {
                k = 1;
            }

            if (checkBox14.Checked == true)
            {
                l = 1;

            }
            if (checkBox15.Checked == true)
            {
                m = 1;
            }
            if (checkBox16.Checked == true)
            {
                n = 1;
            }
            if (checkBox17.Checked == true)
            {
                o = 1;
            }
            if (checkBox18.Checked == true)
            {
                p = 1;
            }
            if (checkBox19.Checked == true)
            {
                q = 1;
            }

            if (checkBox20.Checked == true)
            {
                r = 1;

            }
            if (checkBox21.Checked == true)
            {
                s = 1;
            }
            if (checkBox22.Checked == true)
            {
                t = 1;
            }
            if (checkBox23.Checked == true)
            {
                u = 1;
            }
            if (checkBox24.Checked == true)
            {
                v = 1;
            }
            if (checkBox25.Checked == true)
            {
                xx = 1;

            }
            if (checkBox26.Checked == true)
            {
                yy = 1;
            }
            if (checkBox27.Checked == true)
            {
                zz = 1;
            }
            if (checkBox28.Checked == true)
            {
                aa = 1;
            }
            if (checkBox29.Checked == true)
            {
                bb = 1;
            }
            if (checkBox30.Checked == true)
            {
                cc = 1;

            }
            if (checkBox31.Checked == true)
            {
                dd = 1;
            }
            if (checkBox32.Checked == true)
            {
                ff = 1;
            }
            if (checkBox33.Checked == true)
            {
                gg = 1;
            }
            if (checkBox34.Checked == true)
            {
                hh = 1;
            }

            string pass = textBox12.Text;
            string pass2 = textBox13.Text;
            if (String.Equals(pass, pass2))
            {
               
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Reviewer (FirstName,MiddleInitial,LastName," +
                        "Affiliation,Department,Address,City,State,ZipCode,PhoneNumber,EmailAddress," +
                        "Password,AnalysisOfAlgorithms,Applications,Architecture,ArtificialIntelligence,ComputerEngineering,Curriculum," +
                    "DataStructures,Databases,DistancedLearning,DistributedSystems,EthicalSocietalIssues," +
                    "FirstYearComputing,GenderIssues,GrantWriting,GraphicsImageProcessing,HumanComputerInteraction," +
                    "LaboratoryEnvironments,Literacy,MathematicsInComputing,Multimedia,NetworkingDataCommunications,NonMajorCourses,ObjectOrientedIssues," +
                    "OperatingSystems,ParallelProcessing,Pedagogy,ProgrammingLanguages,Research," +
                    "Security,SoftwareEngineering,SystemsAnalysisAndDesign,UsingTechnologyInTheClassroom,WebAndInternetProgramming,Other,OtherDescription)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + comboBox1.Text + "','" + textBox11.Text + "','" + textBox7.Text + "','" + textBox4.Text + "','" + textBox13.Text + "','" + x + "','" + y + "','" + z + "','" + a + "','" + b + "','" + c + "','" + d + "','" + f + "','" + g + "','" + h + "','" + i + "','" + j + "','" + k + "','" + l + "','" + m + "','" + n + "','" + o + "','" + p + "','" + q + "','" + r + "','" + s + "','" + t + "','" + u + "','" + v + "','" + xx + "','" + yy + "','" + zz + "','" + aa + "','" + bb + "','" + cc + "','" + dd + "','" + ff + "','" + gg + "','" + hh + "','" + textBox20.Text + "')", con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion completed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                this.Hide();
                Form12 f4 = new Form12();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Password dont match");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
