namespace WindowsFormsApp2
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emtxt = new System.Windows.Forms.Label();
            this.Pstxt = new System.Windows.Forms.Label();
            this.Em1txt = new System.Windows.Forms.TextBox();
            this.Ps2txt = new System.Windows.Forms.TextBox();
            this.Ltxt = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.H2txt = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(418, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Emtxt
            // 
            this.Emtxt.AutoSize = true;
            this.Emtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emtxt.Location = new System.Drawing.Point(458, 161);
            this.Emtxt.Name = "Emtxt";
            this.Emtxt.Size = new System.Drawing.Size(58, 20);
            this.Emtxt.TabIndex = 1;
            this.Emtxt.Text = "Email:";
            // 
            // Pstxt
            // 
            this.Pstxt.AutoSize = true;
            this.Pstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pstxt.Location = new System.Drawing.Point(439, 263);
            this.Pstxt.Name = "Pstxt";
            this.Pstxt.Size = new System.Drawing.Size(91, 20);
            this.Pstxt.TabIndex = 2;
            this.Pstxt.Text = "Password:";
            // 
            // Em1txt
            // 
            this.Em1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Em1txt.Location = new System.Drawing.Point(543, 163);
            this.Em1txt.Multiline = true;
            this.Em1txt.Name = "Em1txt";
            this.Em1txt.Size = new System.Drawing.Size(258, 29);
            this.Em1txt.TabIndex = 3;
            // 
            // Ps2txt
            // 
            this.Ps2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ps2txt.Location = new System.Drawing.Point(543, 263);
            this.Ps2txt.Multiline = true;
            this.Ps2txt.Name = "Ps2txt";
            this.Ps2txt.Size = new System.Drawing.Size(258, 32);
            this.Ps2txt.TabIndex = 4;
            // 
            // Ltxt
            // 
            this.Ltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltxt.Location = new System.Drawing.Point(528, 334);
            this.Ltxt.Name = "Ltxt";
            this.Ltxt.Size = new System.Drawing.Size(102, 36);
            this.Ltxt.TabIndex = 5;
            this.Ltxt.Text = "Login";
            this.Ltxt.UseVisualStyleBackColor = true;
            this.Ltxt.Click += new System.EventHandler(this.Ltxt_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Location = new System.Drawing.Point(587, 92);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 29);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Login";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H2txt
            // 
            this.H2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H2txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.H2txt.Location = new System.Drawing.Point(693, 334);
            this.H2txt.Name = "H2txt";
            this.H2txt.Size = new System.Drawing.Size(75, 31);
            this.H2txt.TabIndex = 7;
            this.H2txt.Text = "Home";
            this.H2txt.UseVisualStyleBackColor = true;
            this.H2txt.Click += new System.EventHandler(this.H2txt_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(608, 430);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(528, 385);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 42);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "---------OR-----------\r\nCreate  a new Account";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.woodland_road_falling_leaf_natural_38537;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 554);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.H2txt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Ltxt);
            this.Controls.Add(this.Ps2txt);
            this.Controls.Add(this.Em1txt);
            this.Controls.Add(this.Pstxt);
            this.Controls.Add(this.Emtxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Emtxt;
        private System.Windows.Forms.Label Pstxt;
        private System.Windows.Forms.TextBox Em1txt;
        private System.Windows.Forms.TextBox Ps2txt;
        private System.Windows.Forms.Button Ltxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button H2txt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox4;
    }
}