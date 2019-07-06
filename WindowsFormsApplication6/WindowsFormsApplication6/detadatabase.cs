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
    public partial class detadatabase : Form
    {

        public detadatabase()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=account;username=root;password=");
        private void detadatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }catch(Exception ex) {}
        }

        private void btnonlinecal_Click(object sender, EventArgs e)
        {
            try
            {
                
                int onlinequan, onlineprice,netprice;
                onlinequan = Convert.ToInt32(txtonlinequantity.Text);
                onlineprice = Convert.ToInt32(txtonlineprice.Text);
                netprice = onlinequan * onlineprice;
                textonlinenetprice.Text = Convert.ToString(netprice);
               
            }
            catch(Exception ex) { }
        }

        private void btnofflinecal_Click(object sender, EventArgs e)
        {
            int offlinquan, offprice, offnet;
            offlinquan = Convert.ToInt32(txtofflinequantity.Text);
            offprice = Convert.ToInt32(txtofflineprice.Text);
            offnet = offlinquan * offprice;
            txtofflinenetprice.Text = Convert.ToString(offnet);
        }

        private void btnothercal_Click(object sender, EventArgs e)
        {
            int otherqua, otherpri, othernet;
            otherqua = Convert.ToInt32(txtotherquantity.Text);
            otherpri = Convert.ToInt32(txtotherprice.Text);
            othernet = otherqua * otherpri;
            txtothernetprice.Text = Convert.ToString(othernet);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                adminfinalre form = new adminfinalre();
                form.Show();
                this.Hide();
            }catch(Exception ex) { }
        }

        private void btnonlineinsert_Click(object sender, EventArgs e)  
        {
            try
            {
               
                    con.Open();
               

                MySqlCommand cmd = new MySqlCommand("INSERT INTO online(Date,Name,Address,Telephone,ItemCode,Quantity,price,Netprice) values('" + txtonlinedaynumber.Text + "','" + txtonlinename.Text + "','" + txtonlineaddress.Text + "','" + txtonlinetelephone.Text + "','" + txtonlinecode.Text + "','" + txtonlinequantity.Text + "','" + txtonlineprice.Text + "','"+ textonlinenetprice.Text+ "')", con);
                
                cmd.ExecuteNonQuery();
                    con.Close();
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void cmbonline_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbonline.Items.Add(txtonlinecode.Text);
        }

        private void btnonlineupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update online set Date='" + txtonlinedaynumber.Text + "',Name='" + txtonlinename.Text + "',Address='"+txtonlineaddress.Text+"',Telephone='"+txtonlinetelephone.Text+"',ItemCode='"+txtonlinecode.Text+"',Quantity='"+txtonlinequantity.Text+"',Netprice='"+txtonlineprice.Text+"'where id='" + txtonlineid.Text + "'", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            finally
            {

                con.Close();
            }
        }

        private void btnonlinedelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "delete from online where id='" + txtonlineid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void btnofflineinsert_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO offline(Date,Name,Address,Telephone,ItemCode,Quantity,Price,Netprice) VALUES('" + txtofflinedaynumber.Text + "','" + txtofflinename.Text + "','" + txtofflineaddress.Text + "','" + txtofflinetelephone.Text + "','" + txtofflinecode.Text + "','" + txtofflinequantity.Text + "','" + txtofflineprice.Text + "','"+ txtofflinenetprice.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void btnofflineupdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update offline set Date='" + txtofflinedaynumber.Text + "',Name='" + txtofflinename.Text + "',Address='" + txtofflineaddress.Text + "',Telephone='" + txtofflinetelephone.Text + "',ItemCode='" + txtofflinecode.Text + "',Quantity='" + txtofflinequantity.Text + "',Netprice='" + txtofflineprice.Text + "'where id='" + txtofflineid.Text + "'", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            finally
            {

                con.Close();
            }
        }

        private void btnofflinedelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "delete from offline where id='" + txtofflineid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnotherinser_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO other(Date,Name,Address,Telephone,ItemCode,Quantity,Price,Netvalue) VALUES('" + txtotherdaynumber.Text + "','" + txtothername.Text + "','" + txtotheraddress.Text + "','" + txtothertelephone.Text + "','" + txtothercode.Text + "','" + txtotherquantity.Text + "','" + txtotherprice.Text + "','"+ txtothernetprice.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void btnotherupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update other set Date='" + txtotherdaynumber.Text + "',Name='" + txtothername.Text + "',Address='" + txtotheraddress.Text + "',Telephone='" + txtothertelephone.Text + "',ItemCode='" + txtothercode.Text + "',Quantity='" + txtotherquantity.Text + "',Netvalue='" + txtotherprice.Text + "'where id='" + txtotherid.Text + "'", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            finally
            {

                con.Close();
            }
        }

        private void btnotherdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "delete from offline where id='" + txtotherid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtonlinecode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtofflinecode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtothercode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtonlineprice_TextChanged(object sender, EventArgs e)
        {

        }
        public void Click1()
        {
            txtonlinedaynumber.Text = "";
            txtonlinename.Text = "";
            txtonlineaddress.Text = "";
            txtonlineid.Text = "";
            txtonlinetelephone.Text = "";
            txtonlinecode.Text = "";
            txtonlinequantity.Text = "";
            txtonlineprice.Text = "";
            textonlinenetprice.Text = "";
        }
        private void btnonlineclear_Click(object sender, EventArgs e)
        {
            Click1();
        }
        public void Click2()
        {
            txtofflinedaynumber.Text = "";
            txtofflinename.Text = "";
            txtofflineaddress.Text = "";
            txtofflineid.Text = "";
            txtofflinetelephone.Text = "";
            txtofflinecode.Text = "";
            txtofflinequantity.Text = "";
            txtofflineprice.Text = "";
            txtofflinenetprice.Text = "";
        }
        private void btnofflineclear_Click(object sender, EventArgs e)
        {
            Click2();
        }
        public void Click3()
        {
            txtotherdaynumber.Text = "";
            txtothername.Text = "";
            txtotheraddress.Text = "";
            txtotherid.Text = "";
            txtothertelephone.Text = "";
            txtothercode.Text = "";
            txtotherquantity.Text = "";
            txtotherprice.Text = "";
            txtothernetprice.Text = "";
        }
        private void btnotherother_Click(object sender, EventArgs e)
        {
            Click3();
        }
    }
    }
    

