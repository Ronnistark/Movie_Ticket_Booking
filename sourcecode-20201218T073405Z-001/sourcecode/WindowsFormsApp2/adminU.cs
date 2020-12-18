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
    public partial class adminU : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H268OR0\SQLEXPRESS;Initial Catalog=TF;Integrated Security=True");
        public adminU()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int name =Convert.ToInt32( textBox1.Text);
            int pass = Convert.ToInt32(textBox2.Text);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Table1 SET lefts='{pass}' where ID='{name}' ", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "", ex.StackTrace);
            }
            MessageBox.Show("updated successfully");
            admin r1 = new admin();
            r1.Show();
            this.Hide();
        }

    }
}

