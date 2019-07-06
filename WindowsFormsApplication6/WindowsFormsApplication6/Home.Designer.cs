namespace WindowsFormsApplication6
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnnewuser = new System.Windows.Forms.Button();
            this.btnstopmusic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl12 = new WindowsFormsApplication6.UserControls.UserControl1();
            this.userControl11 = new WindowsFormsApplication6.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnnewuser);
            this.panel1.Controls.Add(this.btnstopmusic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnlog
            // 
            this.btnlog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlog.BackgroundImage")));
            this.btnlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.White;
            this.btnlog.Location = new System.Drawing.Point(551, 0);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(161, 89);
            this.btnlog.TabIndex = 1;
            this.btnlog.Text = "Log In";
            this.btnlog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.ForeColor = System.Drawing.Color.DimGray;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(0, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(171, 89);
            this.btnexit.TabIndex = 1;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnnewuser
            // 
            this.btnnewuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnewuser.BackgroundImage")));
            this.btnnewuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnewuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewuser.ForeColor = System.Drawing.Color.White;
            this.btnnewuser.Location = new System.Drawing.Point(358, 2);
            this.btnnewuser.Name = "btnnewuser";
            this.btnnewuser.Size = new System.Drawing.Size(190, 87);
            this.btnnewuser.TabIndex = 2;
            this.btnnewuser.Text = "New User";
            this.btnnewuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnewuser.UseVisualStyleBackColor = true;
            this.btnnewuser.Click += new System.EventHandler(this.btnnewuser_Click);
            // 
            // btnstopmusic
            // 
            this.btnstopmusic.BackColor = System.Drawing.Color.Transparent;
            this.btnstopmusic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstopmusic.Image = ((System.Drawing.Image)(resources.GetObject("btnstopmusic.Image")));
            this.btnstopmusic.Location = new System.Drawing.Point(174, 2);
            this.btnstopmusic.Name = "btnstopmusic";
            this.btnstopmusic.Size = new System.Drawing.Size(182, 88);
            this.btnstopmusic.TabIndex = 0;
            this.btnstopmusic.Text = "Stop Music";
            this.btnstopmusic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstopmusic.UseVisualStyleBackColor = false;
            this.btnstopmusic.Click += new System.EventHandler(this.btnstopmusic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 88);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(670, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 32);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(638, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 32);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(603, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 32);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(568, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 32);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dutch801 ItHd BT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To Business";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userControl12);
            this.panel3.Controls.Add(this.userControl11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 256);
            this.panel3.TabIndex = 3;
            // 
            // userControl12
            // 
            this.userControl12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl12.BackgroundImage")));
            this.userControl12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl12.Location = new System.Drawing.Point(0, 0);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(711, 256);
            this.userControl12.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(711, 256);
            this.userControl11.TabIndex = 0;
            this.userControl11.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(711, 437);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstopmusic;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnnewuser;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private UserControls.UserControl1 userControl12;
    }
}