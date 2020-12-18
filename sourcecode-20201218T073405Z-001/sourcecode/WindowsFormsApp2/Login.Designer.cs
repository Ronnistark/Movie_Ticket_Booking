namespace WindowsFormsApp2
{
    partial class Login
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
            this.Ftxt = new System.Windows.Forms.Label();
            this.Ltxt = new System.Windows.Forms.Label();
            this.Etxt = new System.Windows.Forms.Label();
            this.Ptxt = new System.Windows.Forms.Label();
            this.Ctxt = new System.Windows.Forms.Label();
            this.Btxt = new System.Windows.Forms.Button();
            this.F1txt = new System.Windows.Forms.TextBox();
            this.L1txt = new System.Windows.Forms.TextBox();
            this.E1txt = new System.Windows.Forms.TextBox();
            this.P1txt = new System.Windows.Forms.TextBox();
            this.C1txt = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.H1txt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(347, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 502);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ftxt
            // 
            this.Ftxt.AutoSize = true;
            this.Ftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ftxt.Location = new System.Drawing.Point(389, 126);
            this.Ftxt.Name = "Ftxt";
            this.Ftxt.Size = new System.Drawing.Size(101, 20);
            this.Ftxt.TabIndex = 1;
            this.Ftxt.Text = "First Name:";
            // 
            // Ltxt
            // 
            this.Ltxt.AutoSize = true;
            this.Ltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltxt.Location = new System.Drawing.Point(390, 195);
            this.Ltxt.Name = "Ltxt";
            this.Ltxt.Size = new System.Drawing.Size(100, 20);
            this.Ltxt.TabIndex = 2;
            this.Ltxt.Text = "Last Name:";
            // 
            // Etxt
            // 
            this.Etxt.AutoSize = true;
            this.Etxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etxt.Location = new System.Drawing.Point(401, 271);
            this.Etxt.Name = "Etxt";
            this.Etxt.Size = new System.Drawing.Size(58, 20);
            this.Etxt.TabIndex = 3;
            this.Etxt.Text = "Email:";
            this.Etxt.Click += new System.EventHandler(this.Etxt_Click);
            // 
            // Ptxt
            // 
            this.Ptxt.AutoSize = true;
            this.Ptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptxt.Location = new System.Drawing.Point(389, 343);
            this.Ptxt.Name = "Ptxt";
            this.Ptxt.Size = new System.Drawing.Size(91, 20);
            this.Ptxt.TabIndex = 5;
            this.Ptxt.Text = "Password:";
            // 
            // Ctxt
            // 
            this.Ctxt.AutoSize = true;
            this.Ctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ctxt.Location = new System.Drawing.Point(354, 422);
            this.Ctxt.Name = "Ctxt";
            this.Ctxt.Size = new System.Drawing.Size(136, 16);
            this.Ctxt.TabIndex = 6;
            this.Ctxt.Text = "Confirm Password:";
            // 
            // Btxt
            // 
            this.Btxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btxt.Location = new System.Drawing.Point(460, 499);
            this.Btxt.Name = "Btxt";
            this.Btxt.Size = new System.Drawing.Size(109, 39);
            this.Btxt.TabIndex = 7;
            this.Btxt.Text = "Submit";
            this.Btxt.UseVisualStyleBackColor = true;
            this.Btxt.Click += new System.EventHandler(this.Btxt_Click);
            // 
            // F1txt
            // 
            this.F1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1txt.Location = new System.Drawing.Point(523, 126);
            this.F1txt.Multiline = true;
            this.F1txt.Name = "F1txt";
            this.F1txt.Size = new System.Drawing.Size(281, 29);
            this.F1txt.TabIndex = 8;
            // 
            // L1txt
            // 
            this.L1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1txt.Location = new System.Drawing.Point(523, 195);
            this.L1txt.Multiline = true;
            this.L1txt.Name = "L1txt";
            this.L1txt.Size = new System.Drawing.Size(281, 31);
            this.L1txt.TabIndex = 9;
            // 
            // E1txt
            // 
            this.E1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E1txt.Location = new System.Drawing.Point(523, 264);
            this.E1txt.Multiline = true;
            this.E1txt.Name = "E1txt";
            this.E1txt.Size = new System.Drawing.Size(281, 27);
            this.E1txt.TabIndex = 10;
            // 
            // P1txt
            // 
            this.P1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1txt.Location = new System.Drawing.Point(523, 343);
            this.P1txt.Multiline = true;
            this.P1txt.Name = "P1txt";
            this.P1txt.Size = new System.Drawing.Size(281, 30);
            this.P1txt.TabIndex = 12;
            // 
            // C1txt
            // 
            this.C1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1txt.Location = new System.Drawing.Point(523, 421);
            this.C1txt.Multiline = true;
            this.C1txt.Name = "C1txt";
            this.C1txt.Size = new System.Drawing.Size(281, 32);
            this.C1txt.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.Location = new System.Drawing.Point(523, 63);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 32);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Register ";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H1txt
            // 
            this.H1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1txt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.H1txt.Location = new System.Drawing.Point(717, 499);
            this.H1txt.Name = "H1txt";
            this.H1txt.Size = new System.Drawing.Size(75, 39);
            this.H1txt.TabIndex = 15;
            this.H1txt.Text = "Home";
            this.H1txt.UseVisualStyleBackColor = true;
            this.H1txt.Click += new System.EventHandler(this.H1txt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.woodland_road_falling_leaf_natural_38537;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 564);
            this.Controls.Add(this.H1txt);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.C1txt);
            this.Controls.Add(this.P1txt);
            this.Controls.Add(this.E1txt);
            this.Controls.Add(this.L1txt);
            this.Controls.Add(this.F1txt);
            this.Controls.Add(this.Btxt);
            this.Controls.Add(this.Ctxt);
            this.Controls.Add(this.Ptxt);
            this.Controls.Add(this.Etxt);
            this.Controls.Add(this.Ltxt);
            this.Controls.Add(this.Ftxt);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Ftxt;
        private System.Windows.Forms.Label Ltxt;
        private System.Windows.Forms.Label Etxt;
        private System.Windows.Forms.Label Ptxt;
        private System.Windows.Forms.Label Ctxt;
        private System.Windows.Forms.Button Btxt;
        private System.Windows.Forms.TextBox F1txt;
        private System.Windows.Forms.TextBox L1txt;
        private System.Windows.Forms.TextBox E1txt;
        private System.Windows.Forms.TextBox P1txt;
        private System.Windows.Forms.TextBox C1txt;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button H1txt;
    }
}