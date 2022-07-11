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
    public partial class Form8 : Form
    {
        
        public Form8()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f2 = new Form9();
            f2.Show();
            
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
                    l= 1;

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
                

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P3BPN85;Initial Catalog=CPMS;Integrated Security=True");
            SqlCommand Comm1 = new SqlCommand("SELECT AuthorID FROM Author WHERE (FirstName = '" + textBox1.Text + "' AND LastName = '" + textBox3.Text + "') ", con);
            con.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                textBox10.Text = DR1.GetValue(0).ToString();
                
            }
            con.Close();
            int local = Convert.ToInt32(textBox10.Text);
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Paper (AuthorID,FilenameOriginal,Filename,Title," +
                    "Certification,NotesToReviewers,AnalysisOfAlgorithms,Applications,Architecture,ArtificialIntelligence,ComputerEngineering,Curriculum," +
                    "DataStructures,Databases,DistanceLearning,DistributedSystems,EthicalSocietalIssues," +
                    "FirstYearComputing,GenderIssues,GrantWriting,GraphicsImageProcessing,HumanComputerInteraction," +
                    "LaboratoryEnvironments,Literacy,MathematicsInComputing,Multimedia,NetworkingDataCommunications,NonMajorCourses,ObjectOrientedIssues," +
                    "OperatingSystems,ParallelsProcessing,Pedagogy,ProgrammingLanguages,Research," +
                    "Security,SoftwareEngineering,SystemsAnalysisAndDesign,UsingTechnologyInTheClassroom,WebAndInternetProgramming,Other,OtherDescription)values('"+ local + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + x + "','" + y + "','" + z + "','" + a + "','" + b + "','" + c + "','" + d + "','" + f + "','" + g + "','" + h + "','" + i + "','" + j + "','" + k + "','" + l + "','" + m + "','" + n + "','" + o + "','" + p + "','" + q + "','" + r + "','" + s + "','" + t + "','" + u + "','" + v + "','" + xx + "','" + yy + "','" + zz + "','" + aa + "','" + bb + "','" + cc + "','" + dd + "','" + ff + "','" + gg + "','" + hh + "','" + textBox5.Text + "')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            this.Hide();
            Form9 f2 = new Form9();
            f2.Show();

        }
    }
}
