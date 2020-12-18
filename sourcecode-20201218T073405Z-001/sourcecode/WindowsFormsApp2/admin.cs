using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Table1", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            adminU r1 = new adminU();
            r1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Register", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
    }
    


