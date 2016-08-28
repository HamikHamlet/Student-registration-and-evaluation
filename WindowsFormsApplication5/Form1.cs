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
    public partial class Form1 : Form
    {
        public static int x;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\AHG\Documents\Visual Studio 2008\Projects\WindowsFormsApplication5\WindowsFormsApplication5\data.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            con.Open();
            com.CommandText = "insert into baza1(id,anun,azganun,tariq,hasce,bjj1,kurs,masn,araj)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +  int.Parse( textBox4.Text) + "','" + textBox5.Text + "','" + int.Parse(textBox8.Text) + "','" + textBox6.Text + "','" + textBox7.Text + "','" + checkedListBox1.Text + "')";
            com.ExecuteNonQuery();
            Form1.x = int.Parse(textBox1.Text);
            con.Close();
            MessageBox.Show("Տվյալները հաջողությամբ լրացվեցին");

            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }

       
    }
}
