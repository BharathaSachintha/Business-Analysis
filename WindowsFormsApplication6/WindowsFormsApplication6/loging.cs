using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication6
{
    public partial class loging : Form
    {
        public loging()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username=null, password=null;
            try
            {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\user\Documents\Login.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                string quary = "Select UserName,Password from userss where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                SqlCommand cmb = new SqlCommand(quary, con);
                SqlDataReader sda = cmb.ExecuteReader();
                //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                //DataTable dt = new DataTable();

                //sda.Fill(dt);
                
                while (sda.Read()) {
                    username = sda["UserName"].ToString();
                    password = sda["Password"].ToString();
                }
                
            
            if (username==textBox1.Text && password==textBox2.Text)
            {


                Form1 form = new Form1();
                form.Show();
                this.Hide();
                    

            }
            else
            {
                MessageBox.Show("Plese check your password");
                   
            }
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            try
            {
                Home form = new Home();
                form.Show();
                this.Hide();
            }
            catch (Exception ex) { }
        }

        private void loging_Load(object sender, EventArgs e)
        {
           
        }

        private void ff(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Enter Username") {

                textBox1.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tt(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {

                textBox2.Text = "";

            }
        }
    }
}
