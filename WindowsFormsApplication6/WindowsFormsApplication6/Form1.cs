using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=account;username=root;password=");
        public Form1()
        {
            InitializeComponent();
            pnlleft.Height = btndash.Height;
            pnlleft.Top = btndash.Top;
        }
        public void chart()
        {
            /*con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from online where Netprice='"+cmbdays.Text.ToString()+"'";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    
                }

            }catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }*/
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndash_Click(object sender, EventArgs e)
        {
            pnlleft.Height = btndash.Height;
            pnlleft.Top = btndash.Top;
        }

        private void btnselle_Click(object sender, EventArgs e)
        {
            pnlleft.Height = btnselle.Height;
            pnlleft.Top = btnselle.Top;
            customer_de form = new customer_de();
            form.Show();
            this.Hide();
        }

        private void btncalender_Click(object sender, EventArgs e)
        {
            pnlleft.Height = btndatabase.Height;
            pnlleft.Top = btndatabase.Top;
            detadatabase form = new detadatabase();
            form.Show();
            this.Hide();
        }

        private void btntask_Click(object sender, EventArgs e)
        {
            pnlleft.Height = btnexit.Height;
            pnlleft.Top = btnexit.Top;
            Application.Exit();
        }

        private void pnlleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Home form = new Home();
                form.Show();
                this.Hide();
            }
            catch (Exception ex) { }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from account.online;", con);
            MySqlDataReader yreder;
            try
            {
                con.Open();
                yreder = cmd.ExecuteReader();
                while(yreder.Read())
                {
                    this.cht2.Series["Netprice"].Points.AddXY(yreder.GetInt32("Date"), yreder.GetInt32("Netprice"));
                    con.Close();
                }
            }catch(Exception ex) { }
        }
    }
}
