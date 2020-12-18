namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1txt = new System.Windows.Forms.Button();
            this.button2txt = new System.Windows.Forms.Button();
            this.comboBox1txt = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slideimage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seattxt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.seattxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.comboBox1txt);
            this.panel2.Controls.Add(this.button2txt);
            this.panel2.Controls.Add(this.button1txt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.slideimage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 333);
            this.panel3.TabIndex = 2;
            // 
            // button1txt
            // 
            this.button1txt.BackColor = System.Drawing.SystemColors.Info;
            this.button1txt.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.media_handler1;
            this.button1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1txt.Location = new System.Drawing.Point(1059, 0);
            this.button1txt.Name = "button1txt";
            this.button1txt.Size = new System.Drawing.Size(97, 43);
            this.button1txt.TabIndex = 1;
            this.button1txt.Text = "Login";
            this.button1txt.UseVisualStyleBackColor = false;
            this.button1txt.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2txt
            // 
            this.button2txt.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.media_handler1;
            this.button2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2txt.Location = new System.Drawing.Point(1196, 0);
            this.button2txt.Name = "button2txt";
            this.button2txt.Size = new System.Drawing.Size(89, 43);
            this.button2txt.TabIndex = 2;
            this.button2txt.Text = "Register";
            this.button2txt.UseVisualStyleBackColor = true;
            this.button2txt.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1txt
            // 
            this.comboBox1txt.DisplayMember = "Banglore";
            this.comboBox1txt.FormattingEnabled = true;
            this.comboBox1txt.Location = new System.Drawing.Point(847, 22);
            this.comboBox1txt.Name = "comboBox1txt";
            this.comboBox1txt.Size = new System.Drawing.Size(152, 21);
            this.comboBox1txt.TabIndex = 3;
            this.comboBox1txt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // slideimage
            // 
            this.slideimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideimage.Enabled = false;
            this.slideimage.ErrorImage = global::WindowsFormsApp2.Properties.Resources._7;
            this.slideimage.Image = ((System.Drawing.Image)(resources.GetObject("slideimage.Image")));
            this.slideimage.ImageLocation = "";
            this.slideimage.Location = new System.Drawing.Point(0, 0);
            this.slideimage.Name = "slideimage";
            this.slideimage.Size = new System.Drawing.Size(1297, 333);
            this.slideimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideimage.TabIndex = 0;
            this.slideimage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.media_handler1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // seattxt
            // 
            this.seattxt.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.media_handler1;
            this.seattxt.Location = new System.Drawing.Point(597, 28);
            this.seattxt.Name = "seattxt";
            this.seattxt.Size = new System.Drawing.Size(148, 60);
            this.seattxt.TabIndex = 0;
            this.seattxt.Text = "Book a seat";
            this.seattxt.UseVisualStyleBackColor = true;
            this.seattxt.Click += new System.EventHandler(this.seattxt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.media_handler1;
            this.pictureBox2.Location = new System.Drawing.Point(152, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1161, 49);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Events";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sports";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Activities";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Buzz";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1059, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Offers";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1186, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "GiftCards";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(920, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "Fanhoods";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(760, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 32);
            this.button8.TabIndex = 12;
            this.button8.Text = "Plays";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 91);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(175, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(628, 29);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "search a movie to book a ticket................................\r\n";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(1006, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(291, 100);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "                              Contact US\r\n \r\nfacebook:-  bookmyshow\r\n\r\nInstagram " +
    ":- bookmyshow\r\n\r\nCustomer care number:9999***********\r\n ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1297, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slideimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1txt;
        private System.Windows.Forms.Button button2txt;
        internal System.Windows.Forms.Button button1txt;
        private System.Windows.Forms.PictureBox slideimage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button seattxt;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

