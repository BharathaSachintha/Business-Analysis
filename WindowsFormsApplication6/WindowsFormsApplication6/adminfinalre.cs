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
    public partial class adminfinalre : Form
    {
        public adminfinalre()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=account;username=root;password=");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                detadatabase form = new detadatabase();
                form.Show();
                this.Hide();
            }catch(Exception ex){}
        }
        void Show()
        {

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select Netprice from online", con);
                MySqlCommand cmb = new MySqlCommand("select Netprice from offline", con);
                MySqlCommand cmv = new MySqlCommand("select Netvalue from other", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataAdapter db = new MySqlDataAdapter(cmb);
                MySqlDataAdapter dc = new MySqlDataAdapter(cmv);
                DataTable dt = new DataTable();
                DataTable dr = new DataTable();
                DataTable dy = new DataTable();
                da.Fill(dt);
                db.Fill(dr);
                dc.Fill(dy);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dr;
                dataGridView3.DataSource = dy;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                con.Close();


            }
        }
        private void adminfinalre_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttotalsell_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count;++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }
            try
            {
                decimal tot = 0;
                for(int i=0;i<=dataGridView1.RowCount -1;i++)
                {
                    tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[0].Value);
                }
                if(tot==0)
                {

                }
                txtday1.Text = tot.ToString();

            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
            }
            try
            {
                decimal tot = 0;
                for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
                {
                    tot += Convert.ToDecimal(dataGridView2.Rows[i].Cells[0].Value);
                }
                if (tot == 0)
                {

                }
                txtday2.Text = tot.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value);
            }
            try
            {
                decimal tot = 0;
                for (int i = 0; i <= dataGridView3.RowCount - 1; i++)
                {
                    tot += Convert.ToDecimal(dataGridView3.Rows[i].Cells[0].Value);
                }
                if (tot == 0)
                {

                }
                txtday3.Text = tot.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btngetNetsell_Click(object sender, EventArgs e)
        {
            int m1, m2, m3,tot;
            m1 = Convert.ToInt32(txtday1.Text);
            m2 = Convert.ToInt32(txtday2.Text);
            m3 = Convert.ToInt32(txtday3.Text);
            tot = m1 + m2 + m3;
            txttotalsell.Text = Convert.ToString(tot);
        }

        private void btngetprofi_Click(object sender, EventArgs e)
        {
            float m1, m2, tot;
            m1 = Convert.ToInt32(txttotalbuy.Text);
            m2 = Convert.ToInt32(txttotalsell.Text);
            tot = m1 - m2;
            txtlostprofit.Text = Convert.ToString(tot);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }
    }
}
