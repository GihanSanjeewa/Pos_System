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
    public partial class frm_purchasing : Form
    {
        public frm_purchasing()
        {
            InitializeComponent();
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            cls_connection.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `purchasing` (`item_name`,`quantity`,invoiced_date,unit_price) VALUES (@item_name,@quantity,@invoiced_date,unit_price)", cls_connection.con);
            cmd.Parameters.Clear();

         ;
          
            cmd.Parameters.AddWithValue("@item_name", cmb_itemName.Text);
            cmd.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            cmd.Parameters.AddWithValue("@invoiced_date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@unit_price", txt_unitPrice.Text);


            cmd.ExecuteNonQuery();
            cls_connection.close_connection();

            MessageBox.Show("Order Added Successfully!");
            addToStock();
            fndataLoad();
        }
        public void addToStock()
        {

            cls_connection.open_connection();
            string sqlqry4 = "update  stock set quantity =quantity +  " + txt_quantity.Text + " where item_name = '" + cmb_itemName.Text + "'";


            MySqlCommand cmd4 = new MySqlCommand(sqlqry4, cls_connection.con);

            cmd4.ExecuteNonQuery();
            cls_connection.close_connection();
            fndataLoad();
        }
        public void fndataLoad()
        {

            MySqlDataAdapter da = new MySqlDataAdapter("Select * from purchasing", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "purchasing");
            DataGridView1.DataSource = ds.Tables["purchasing"].DefaultView;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }

        private void frm_purchasing_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from item", cls_connection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_itemName.Items.Add(dt.Rows[i]["item_name"]);
              


            }
            fndataLoad();
        }
    }
}
