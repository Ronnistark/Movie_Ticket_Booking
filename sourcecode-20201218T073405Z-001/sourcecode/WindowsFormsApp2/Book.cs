using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Book : Form
    {
      

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");

        public Book()
        {
            InitializeComponent();
          
        }

        private void b4txt_Click(object sender, EventArgs e)
        {
           
                SeatPage s4 = new SeatPage();
               s4.passingvalue = textBox11.Text;
               s4.Show();
                this.Hide();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SeatPage s4 = new SeatPage();
            s4.passingvalue = textBox12.Text;
            s4.Show();
            this.Hide();
        }

        private void Htxt_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void b1txt_Click(object sender, EventArgs e)
        {
            SeatPage s4 = new SeatPage();
            s4.passingvalue = textBox8.Text;
            s4.Show();
            this.Hide();
        }

        private void b2txt_Click(object sender, EventArgs e)
        {
            
            SeatPage s4 = new SeatPage();
            s4.passingvalue = textBox9.Text;
            s4.Show();
            this.Hide();
        }

        private void b3txt_Click(object sender, EventArgs e)
        {
            
            SeatPage s4 = new SeatPage();
            s4.passingvalue = textBox10.Text;
            s4.Show();
            this.Hide();
        }

        private void b6txt_Click(object sender, EventArgs e)
        {
            
            SeatPage s4 = new SeatPage();
            s4.passingvalue = textBox13.Text;
            s4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
