namespace VTS
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.uname = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.utbox = new System.Windows.Forms.TextBox();
            this.ptbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.PictureBox();
            this.ig = new System.Windows.Forms.PictureBox();
            this.ciu = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).BeginInit();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.BackColor = System.Drawing.SystemColors.Control;
            this.uname.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(121, 216);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(108, 28);
            this.uname.TabIndex = 0;
            this.uname.Text = "Username :";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.SystemColors.Control;
            this.pwd.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pwd.Location = new System.Drawing.Point(121, 252);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(112, 28);
            this.pwd.TabIndex = 0;
            this.pwd.Text = "Password  :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-2, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 174);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(-2, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(589, 35);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Login to Your Account";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // utbox
            // 
            this.utbox.Location = new System.Drawing.Point(235, 224);
            this.utbox.Name = "utbox";
            this.utbox.Size = new System.Drawing.Size(145, 20);
            this.utbox.TabIndex = 1;
            this.utbox.Text = "admin";
            // 
            // ptbox
            // 
            this.ptbox.Location = new System.Drawing.Point(235, 260);
            this.ptbox.Name = "ptbox";
            this.ptbox.PasswordChar = '*';
            this.ptbox.Size = new System.Drawing.Size(145, 20);
            this.ptbox.TabIndex = 2;
            this.ptbox.Text = "admin";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.loginbtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(297, 297);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(83, 28);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(423, 224);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Don\'t Have An Account? ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signupbtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupbtn.Location = new System.Drawing.Point(489, 253);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(83, 28);
            this.signupbtn.TabIndex = 4;
            this.signupbtn.Text = "SIGN UP";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // fb
            // 
            this.fb.BackColor = System.Drawing.SystemColors.Control;
            this.fb.Image = ((System.Drawing.Image)(resources.GetObject("fb.Image")));
            this.fb.Location = new System.Drawing.Point(12, 323);
            this.fb.Name = "fb";
            this.fb.Size = new System.Drawing.Size(26, 26);
            this.fb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fb.TabIndex = 5;
            this.fb.TabStop = false;
            this.fb.Click += new System.EventHandler(this.fb_Click);
            // 
            // ig
            // 
            this.ig.BackColor = System.Drawing.SystemColors.Control;
            this.ig.Image = ((System.Drawing.Image)(resources.GetObject("ig.Image")));
            this.ig.Location = new System.Drawing.Point(44, 323);
            this.ig.Name = "ig";
            this.ig.Size = new System.Drawing.Size(26, 26);
            this.ig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ig.TabIndex = 5;
            this.ig.TabStop = false;
            this.ig.Click += new System.EventHandler(this.ig_Click);
            // 
            // ciu
            // 
            this.ciu.BackColor = System.Drawing.SystemColors.Control;
            this.ciu.Image = ((System.Drawing.Image)(resources.GetObject("ciu.Image")));
            this.ciu.Location = new System.Drawing.Point(76, 323);
            this.ciu.Name = "ciu";
            this.ciu.Size = new System.Drawing.Size(26, 26);
            this.ciu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciu.TabIndex = 5;
            this.ciu.TabStop = false;
            this.ciu.Click += new System.EventHandler(this.ciu_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Image = global::VTS.Properties.Resources.cpy;
            this.pictureBox4.Location = new System.Drawing.Point(149, 338);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(169, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright 2023";
            // 
            // twitter
            // 
            this.twitter.BackColor = System.Drawing.SystemColors.Control;
            this.twitter.Image = global::VTS.Properties.Resources.twitter;
            this.twitter.Location = new System.Drawing.Point(108, 323);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(35, 26);
            this.twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twitter.TabIndex = 5;
            this.twitter.TabStop = false;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VTS.Properties.Resources.backimage;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.ciu);
            this.Controls.Add(this.ig);
            this.Controls.Add(this.fb);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.ptbox);
            this.Controls.Add(this.utbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.Text = "Vehicle Tracking System";
            ((System.ComponentModel.ISupportInitialize)(this.fb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox utbox;
        private System.Windows.Forms.TextBox ptbox;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.PictureBox fb;
        private System.Windows.Forms.PictureBox ig;
        private System.Windows.Forms.PictureBox ciu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox twitter;
    }
}

