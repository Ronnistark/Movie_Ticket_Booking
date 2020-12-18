using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login s1 = new Login();
            s1.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Register s1 = new Register();
            s1.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            slideimage.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seattxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login First to Book a seat");
            Register r1 = new Register();
            r1.Show();
            this.Hide();


        }
    }
}
