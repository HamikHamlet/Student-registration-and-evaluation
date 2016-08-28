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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\AHG\Documents\Visual Studio 2008\Projects\WindowsFormsApplication5\WindowsFormsApplication5\data.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com = new SqlCommand();

        public Form3()
        {
            InitializeComponent();
        }

        private void id(object sender, EventArgs e)
        
            
        {
            textBox1.Text = Form1.x.ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            con.Open();
            com.CommandText = "insert into baza2(id,mek,erku,ereq,chors,hing)values('" + textBox1.Text + "','" + checkedListBox1.Text + "','" + checkedListBox2.Text + "','" + checkedListBox3.Text + "','" + checkedListBox4.Text + "','" + checkedListBox5.Text + "')";
            com.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show(" Տվյալները հաջողությամբ լրացվեցին");

            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
