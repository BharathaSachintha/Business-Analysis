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
    public partial class customer_de : Form
    {
        public customer_de()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=account;username=root;password=");
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void customer_de_Load(object sender, EventArgs e)
        {
            Show();

        }
        void Show()
        {

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from online", con);
                MySqlCommand cmb = new MySqlCommand("select * from offline", con);
                MySqlCommand cmv = new MySqlCommand("select * from other", con);
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
    }
}
