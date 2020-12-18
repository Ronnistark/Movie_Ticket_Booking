using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
            Ps2txt.PasswordChar = '.';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void H2txt_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            f3.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login f3 = new Login();
            f3.Show();
            this.Hide();
        }

        private void Ltxt_Click(object sender, EventArgs e)
        {
            if (Em1txt.Text=="admin" && Ps2txt.Text=="admin")
            {
                admin a1 = new admin();
                a1.Show();
                this.Hide();
            }
            else {
                string query = "select * from Register where Email='" + Em1txt.Text.Trim() + "' and password = '" + Ps2txt.Text.Trim() + "'";
                SqlDataAdapter c1 = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                c1.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful\n start booking Ticket");
                    Book s5 = new Book();
                    this.Hide();
                    s5.Show();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                    Em1txt.Clear();
                    Ps2txt.Clear();

                }
            }


        }


    }
    }

