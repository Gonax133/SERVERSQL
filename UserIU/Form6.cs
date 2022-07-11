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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P3BPN85;Initial Catalog=CPMS;Integrated Security=True"); 
        
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
            double z = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double f = 0;
            double g = 0;
            double h = 0;
            double i = 0;
            double j = 0;
            
            double p = 0;


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

            if (comboBox3.Text == "Excellent")
            {
                z = 5.0;
            }
                if (comboBox3.Text == "Good")
                {
                    z = 4.0;
                }
                    if (comboBox3.Text == "Average")
                    {
                        z = 3.0;
                    }

                        if (comboBox3.Text == "Fair")
                        {
                            z = 2.0;
                        }
                            if (comboBox3.Text == "Poor")
                            {
                                z = 1.0;
                            }

            if (comboBox4.Text == "Excellent")
            {
                a = 5.0;
            }
                if (comboBox4.Text == "Good")
                {
                    a = 4.0;
                }
                    if (comboBox4.Text == "Average")
                    {
                        a = 3.0;
                    }

                        if (comboBox4.Text == "Fair")
                        {
                            a = 2.0;
                        }
                            if (comboBox4.Text == "Poor")
                            {
                                a = 1.0;
                            }

            if (comboBox5.Text == "Excellent")
            {
                b = 5.0;
            }
                if (comboBox5.Text == "Good")
                {
                    b = 4.0;
                }
                    if (comboBox5.Text == "Average")
                    {
                        b = 3.0;
                    }

                        if (comboBox5.Text == "Fair")
                        {
                            b = 2.0;
                        }
                            if (comboBox5.Text == "Poor")
                            {
                                b = 1.0;
                            }

            if (comboBox6.Text == "Excellent")
            {
                c = 5.0;
            }
                if (comboBox6.Text == "Good")
                {
                    c = 4.0;
                }
                    if (comboBox6.Text == "Average")
                    {
                        c = 3.0;
                    }

                        if (comboBox6.Text == "Fair")
                        {
                            c = 2.0;
                        }
                            if (comboBox6.Text == "Poor")
                            {
                                c = 1.0;
                            }

            if (comboBox7.Text == "Excellent")
            {
                d = 5.0;
            }
                if (comboBox7.Text == "Good")
                {
                    d = 4.0;
                }
                    if (comboBox7.Text == "Average")
                    {
                        d = 3.0;
                    }

                        if (comboBox7.Text == "Fair")
                        {
                            d = 2.0;
                        }
                            if (comboBox7.Text == "Poor")
                            {
                                d = 1.0;
                            }

            if (comboBox8.Text == "Excellent")
            {
                f = 5.0;
            }
                if (comboBox8.Text == "Good")
                {
                    f = 4.0;
                }
                    if (comboBox8.Text == "Average")
                    {
                        f = 3.0;
                    }

                        if (comboBox8.Text == "Fair")
                        {
                            f = 2.0;
                        }
                            if (comboBox8.Text == "Poor")
                            {
                                f = 1.0;
                            }

            if (comboBox9.Text == "Excellent")
            {
                g = 5.0;
            }
                if (comboBox9.Text == "Good")
                {
                    g = 4.0;
                }
                    if (comboBox9.Text == "Average")
                    {
                        g = 3.0;
                    }

                        if (comboBox9.Text == "Fair")
                        {
                            g = 2.0;
                        }
                            if (comboBox9.Text == "Poor")
                            {
                                g = 1.0;
                            }

            if (comboBox10.Text == "Excellent")
            {
                h = 5.0;
            }
                if (comboBox10.Text == "Good")
                {
                    h = 4.0;
                }
                    if (comboBox10.Text == "Average")
                    {
                        h = 3.0;
                    }

                        if (comboBox10.Text == "Fair")
                        {
                            h = 2.0;
                        }
                            if (comboBox10.Text == "Poor")
                            {
                                h = 1.0;
                            }
            if (comboBox11.Text == "Excellent")
            {
                i = 5.0;
            }
                if (comboBox11.Text == "Good")
                {
                    i = 4.0;
                }
                    if (comboBox11.Text == "Average")
                    {
                        i = 3.0;
                    }

                        if (comboBox11.Text == "Fair")
                        {
                            i = 2.0;
                        }
                            if (comboBox11.Text == "Poor")
                            {
                                i = 1.0;
                            }


            if (comboBox12.Text == "Excellent")
            {
                j = 5.0;
            }
                if (comboBox12.Text == "Good")
                {
                    j = 4.0;
                }
                    if (comboBox12.Text == "Average")
                    {
                        j = 3.0;
                    }

                        if (comboBox12.Text == "Fair")
                        {
                            j = 2.0;
                        }
                            if (comboBox12.Text == "Poor")
                            {
                                j = 1.0;
                            }


            if (comboBox16.Text == "Definitely Should Accept Paper")
            {
                p = 5.0;
            }
            if (comboBox16.Text == "Probably Should Accept Paper")
            {
                p = 4.0;
            }
            if (comboBox16.Text == "Uncertain About Acceptance of Paper")
            {
                p = 3.0;
            }

            if (comboBox16.Text == "Probably Should Not Accept Paper")
            {
                p = 2.0;
            }
            if (comboBox16.Text == "Definitely Should Not Accept Paper")
            {
                p = 1.0;
            }

            
            SqlCommand Comm1 = new SqlCommand("SELECT PaperID FROM Paper WHERE ( Title= '" + textBox4.Text + "') ", con);
            con.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                textBox5.Text = DR1.GetValue(0).ToString();

            }
            con.Close();
            int local = Convert.ToInt32(textBox5.Text);

            SqlCommand Comm2 = new SqlCommand("SELECT ReviewerID FROM Reviewer WHERE ( FirstName = '" + textBox1.Text + "' AND LastName = '" + textBox3.Text + "') ", con);
            con.Open();
            SqlDataReader DR2 = Comm2.ExecuteReader();
            if (DR2.Read())
            {
                textBox6.Text = DR2.GetValue(0).ToString();

            }
            con.Close();
            int local1 = Convert.ToInt32(textBox6.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Review (PaperID,ReviewerID,AppropriatenessOfTopic,TimelinessOfTopic,SupportiveEvidence,TechnicalQuality,ScopeOfCoverage,CitationOfPreviousWork,Originality,ContentComments,OrganizationOfPaper,ClarityOfMainMessage,Mechanics,WrittenDocumentComments,SuitabilityForPresentation,PotentialInterestInTopic,PotentialForOralPresentationComments,OverallRating,OverallRatingComments,ComfortLevelTopic,ComfortLevelAcceptability,Complete)values('" + local + "','" + local1 + "','" + x + "','" + y + "','" + z + "','" + a + "','" + b + "','" + c + "','" + d + "','" + richTextBox1.Text + "','" + f + "','" + g + "','" + h + "','" + richTextBox2.Text + "','" + i + "','" + j + "','"+ richTextBox3.Text+"','"+ p + "','"+richTextBox4.Text+ "','" + 1 + "','" + 1 + "','"+ 1 + "')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion completed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            this.Hide();
            Form12 f7 = new Form12();
            f7.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f7 = new Form12();
            f7.Show();
        }
    }
}
