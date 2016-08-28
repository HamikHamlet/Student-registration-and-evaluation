using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        double c;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\AHG\Documents\Visual Studio 2008\Projects\WindowsFormsApplication5\WindowsFormsApplication5\data.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com = new SqlCommand();
        SqlDataReader red;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = (int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text) + int.Parse(textBox13.Text) + int.Parse(textBox14.Text));
            c = c / 5;
            textBox15.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select * from baza1 where id = '" + textBox1.Text + "' ", con);
            SqlDataReader red;
            red = com.ExecuteReader();
            if (red.Read())
            {
                textBox2.Text = red["anun"].ToString().Trim();
                textBox3.Text = red["azganun"].ToString().Trim();
                textBox4.Text = red["tariq"].ToString().Trim();
                textBox5.Text = red["hasce"].ToString().Trim();
                textBox6.Text = red["bjj1"].ToString().Trim();
                textBox7.Text = red["kurs"].ToString().Trim();
                textBox8.Text = red["masn"].ToString().Trim();
                textBox9.Text = red["araj"].ToString().Trim();
                




            }
            else
            {
                MessageBox.Show("Ձեր Մուտքագրված ID Code գոյություն չունի");

            }

            con.Close();
        }

        private void id(object sender, MouseEventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select * from baza2 where id = '" + textBox1.Text + "' ", con);
            SqlDataReader red;
            red = com.ExecuteReader();
            if (red.Read())
            {
                textBox10.Text = red["mek"].ToString().Trim();
                textBox11.Text = red["erku"].ToString().Trim();
                textBox12.Text = red["ereq"].ToString().Trim();
                textBox13.Text = red["chors"].ToString().Trim();
                textBox14.Text = red["hing"].ToString().Trim();
                





            }
            else
            {
                MessageBox.Show("Ձեր Մուտքագրված ID Code գոյություն չունի");

            }

            con.Close();
        }

        
    }
}
