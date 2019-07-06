namespace WindowsFormsApplication6
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
            System.Windows.Forms.DataVisualization.Charting.Chart cht1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new WindowsFormsApplication6.accountDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndatabase = new System.Windows.Forms.Button();
            this.btnselle = new System.Windows.Forms.Button();
            this.btndash = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cht2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlleft = new System.Windows.Forms.Panel();
            cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(cht1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cht1
            // 
            chartArea1.Name = "ChartArea1";
            cht1.ChartAreas.Add(chartArea1);
            cht1.DataSource = this.bindingSource1;
            legend1.Name = "Legend1";
            cht1.Legends.Add(legend1);
            cht1.Location = new System.Drawing.Point(159, 91);
            cht1.Name = "cht1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Online";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Offline";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Other";
            cht1.Series.Add(series1);
            cht1.Series.Add(series2);
            cht1.Series.Add(series3);
            cht1.Size = new System.Drawing.Size(543, 177);
            cht1.TabIndex = 9;
            cht1.Text = "chart1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.accountDataSet;
            this.bindingSource1.Position = 0;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "accountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndatabase);
            this.panel1.Controls.Add(this.btnselle);
            this.panel1.Controls.Add(this.btndash);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(0, 382);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(137, 76);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btntask_Click);
            // 
            // btndatabase
            // 
            this.btndatabase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndatabase.BackgroundImage")));
            this.btndatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndatabase.FlatAppearance.BorderSize = 0;
            this.btndatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndatabase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatabase.ForeColor = System.Drawing.Color.White;
            this.btndatabase.Location = new System.Drawing.Point(0, 300);
            this.btndatabase.Name = "btndatabase";
            this.btndatabase.Size = new System.Drawing.Size(137, 76);
            this.btndatabase.TabIndex = 3;
            this.btndatabase.Text = "Add  Details";
            this.btndatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndatabase.UseVisualStyleBackColor = true;
            this.btndatabase.Click += new System.EventHandler(this.btncalender_Click);
            // 
            // btnselle
            // 
            this.btnselle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnselle.BackgroundImage")));
            this.btnselle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnselle.FlatAppearance.BorderSize = 0;
            this.btnselle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselle.ForeColor = System.Drawing.Color.White;
            this.btnselle.Location = new System.Drawing.Point(0, 218);
            this.btnselle.Name = "btnselle";
            this.btnselle.Size = new System.Drawing.Size(137, 76);
            this.btnselle.TabIndex = 2;
            this.btnselle.Text = "Customers";
            this.btnselle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnselle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnselle.UseVisualStyleBackColor = true;
            this.btnselle.Click += new System.EventHandler(this.btnselle_Click);
            // 
            // btndash
            // 
            this.btndash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndash.BackgroundImage")));
            this.btndash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndash.FlatAppearance.BorderSize = 0;
            this.btndash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndash.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.ForeColor = System.Drawing.Color.White;
            this.btndash.Location = new System.Drawing.Point(0, 127);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(137, 76);
            this.btndash.TabIndex = 1;
            this.btndash.Text = "Dashboard";
            this.btndash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndash.UseVisualStyleBackColor = true;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 120);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cht2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(140, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 177);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cht2
            // 
            chartArea2.Name = "ChartArea1";
            this.cht2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht2.Legends.Add(legend2);
            this.cht2.Location = new System.Drawing.Point(19, 16);
            this.cht2.Name = "cht2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Online";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Offline";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Other";
            this.cht2.Series.Add(series4);
            this.cht2.Series.Add(series5);
            this.cht2.Series.Add(series6);
            this.cht2.Size = new System.Drawing.Size(365, 147);
            this.cht2.TabIndex = 11;
            this.cht2.Text = "chart2";
            this.cht2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(491, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(19, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Selles";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(631, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Week";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.Yellow;
            this.pnlleft.Location = new System.Drawing.Point(140, 127);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(7, 76);
            this.pnlleft.TabIndex = 8;
            this.pnlleft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlleft_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(731, 461);
            this.Controls.Add(cht1);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(cht1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndatabase;
        private System.Windows.Forms.Button btnselle;
        private System.Windows.Forms.Button btndash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private accountDataSet accountDataSet;
        private System.Windows.Forms.Button button2;
    }
}

