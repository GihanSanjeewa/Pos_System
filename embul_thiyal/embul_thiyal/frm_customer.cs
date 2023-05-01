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
using System.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace embul_thiyal
{
    public partial class frm_customer : Form
    {
        public frm_customer()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

   

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from lcustomer", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "lcustomer");
            dgv_customer.DataSource = ds.Tables["lcustomer"].DefaultView;

            cls_connection.close_connection();

        }

        private void btn_search_customer_Click(object sender, EventArgs e)
        {
            cls_connection.open_connection();

            string MysqlQry = "delete from lcustomer where m_number =(" + txt_mobile_number.Text + ")";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, cls_connection.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Done!!");

            cls_connection.close_connection();


            fndataLoad();
        }

        private void txt_mobile_number_TextChanged(object sender, EventArgs e)
        {
            fndataLoad();
        }
    }
}
