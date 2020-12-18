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
using System.Windows.Forms.ComponentModel;


namespace WindowsFormsApp2
{
    public partial class SeatPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");
        public string name;

      
public string passingvalue
        {

            get { return name; }
            set { name = value; }
        }


        public SeatPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g;

            if (r1.Checked == true)
            {
                g = 1;

            }
            else if (r2.Checked == true)
            {
                g = 2;

            }
            else
            {
                g = 3;

            }

            SqlCommand cmd = new SqlCommand("insert into Seat values(@dates,@time,@seats,@ID)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dates", C1.SelectedItem);
            cmd.Parameters.AddWithValue("@time", C2.SelectedItem);
            cmd.Parameters.AddWithValue("@seats", g);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
          
                const string message =
                    " Good choice Boy\nAre you sure that you want to submit form or \n else press NO for edit?";
                const string caption = "Form Submission";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Form1 f6 = new Form1();
                f6.Show();
                this.Hide();
            }
            else
            {
                update u1 = new update();
                u1.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeatPage_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + name;
        }

       

        private void button3_Click_3(object sender, EventArgs e)
        {
            int g;

            if (r1.Checked == true)
            {
                g = 1;

            }
            else if (r2.Checked == true)
            {
                g = 2;

            }
            else
            {
                g = 3;

            }
            //int i = Convert.ToInt32(textBox1.Text);
            SqlCommand cmd = new SqlCommand($"update Table1 set lefts=lefts-'{g}' where ID=" + textBox1.Text + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
