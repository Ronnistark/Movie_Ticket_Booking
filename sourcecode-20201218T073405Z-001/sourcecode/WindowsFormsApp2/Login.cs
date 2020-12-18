using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
            P1txt.PasswordChar = '.';
            C1txt.PasswordChar = '.';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Etxt_Click(object sender, EventArgs e)
        {

        }

        private void H1txt_Click(object sender, EventArgs e)
        {
            
           
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void Btxt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Register values(@Fname,@Lname,@Email,@Pass,@confirm)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Fname", F1txt.Text);
            cmd.Parameters.AddWithValue("@Lname", L1txt.Text);
            cmd.Parameters.AddWithValue("@Email", E1txt.Text);
            cmd.Parameters.AddWithValue("@Pass", P1txt.Text);
            cmd.Parameters.AddWithValue("@confirm", C1txt.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Welcome to Book My show\n start Booking Ticket ");
            Register r1 = new Register();
            r1.Show();
            this.Hide();
        }
    }
}
