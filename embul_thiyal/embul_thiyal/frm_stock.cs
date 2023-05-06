using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace embul_thiyal
{
    public partial class frm_stock : Form
    {
        public frm_stock()
        {
            InitializeComponent();
        }

        private void frm_stock_Load(object sender, EventArgs e)
        {

            MySqlDataAdapter da = new MySqlDataAdapter("select * from item", cls_connection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {



            }
            fndataLoad();
        }
        public void fndataLoad()
        {

            MySqlDataAdapter da = new MySqlDataAdapter("Select * from stock", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stock");
            DataGridView1.DataSource = ds.Tables["stock"].DefaultView;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }
    }
}
