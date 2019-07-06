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
    public partial class create_new_user : Form
    {
        public create_new_user()
        {
            InitializeComponent();
            
            dtpdateofbirthday.MaxDate = DateTime.Today.AddYears(2);
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=account;username=root;password=");
        private void create_new_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                loging form = new loging();
                form.Show();
                this.Hide();
            }
            catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Home form=new Home();
                form.Show();
                this.Hide();
            }catch(Exception ex) { }
        }

        private void dtpdateofbirthday_ValueChanged(object sender, EventArgs e)
        {
           // txtdateofbirth.Text = dtpdateofbirthday.Value.Month.ToString();
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into acountdetails(First_Name,Last_Name,Email_Address,Telephone_Number,User_Name,Password,Conform_Password,Date_Of_Birth,Address,City,State,Zip_Code)values('" +txtfirstname.Text + "','" + txtlastname.Text + "','"+txtemail.Text+"','"+txttelephonenumber.Text+"','"+txtusername.Text+"','"+txtpassword.Text+"','"+txtpasswordconform.Text+"','"+dtpdateofbirthday.ToString()+"','"+txtaddress.Text+"','"+txtcity.Text+"','"+txtstate.Text+"','"+txtzipcode.Text+"')", con);
                
                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Account Create Thank You");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
