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


namespace WindowsFormsApp2
{
    public partial class update : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");
        public update()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Register SET password='{pass}',confirm='{pass}' where FirstName='{name}' ", con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "", ex.StackTrace);
            }
            MessageBox.Show("updated successfully");
            Register r1 = new Register();
            r1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"delete from Register where FirstName='{name}' ", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "", ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
