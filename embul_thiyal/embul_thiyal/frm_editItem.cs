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
    public partial class frm_editItem : Form
    {
        public frm_editItem()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cls_connection.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `item_id`,`item_name`,`item_price`,`category` FROM `item` WHERE item_name =@id", cls_connection.con);
            cmd1.Parameters.AddWithValue("id", txt_searchName.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_itemCode.Text = reader1["item_id"].ToString();
                txt_itemName.Text = reader1["item_name"].ToString();
                cmb_category.Text = reader1["category"].ToString();
                txt_unitPrice.Text = reader1["item_price"].ToString();


               

            }
            else
            {
                MessageBox.Show("No data found");
            }
            cls_connection.close_connection();
        }

        private void frm_editItem_Load(object sender, EventArgs e)
        {
            fndataLoad();
        }
        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item.DataSource = ds.Tables["item"].DefaultView;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cls_connection.open_connection();

            string MysqlQry = "update item set item_name =('" + txt_itemName.Text + "'),category =('" + cmb_category.Text + "'),item_price=(" + txt_unitPrice.Text + ") where item_id = (" + txt_itemCode.Text + ")";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, cls_connection.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Done!!");

            cls_connection.close_connection();


            fndataLoad();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cls_connection.open_connection();

            string MysqlQry = "delete from item where item_id =(" + txt_itemCode.Text + ")";

            MySqlCommand cmd = new MySqlCommand(MysqlQry, cls_connection.con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Done!!");

            cls_connection.close_connection();


            fndataLoad();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1) 
            {
                DataGridViewRow dgvrow = dgv_item.Rows[e.RowIndex];
                txt_itemCode.Text = dgvrow.Cells[0].Value.ToString();
                txt_itemName.Text = dgvrow.Cells[1].Value.ToString();
                cmb_category.Text = dgvrow.Cells[3].Value.ToString();
                txt_unitPrice.Text = dgvrow.Cells[2].Value.ToString();

            }
        }
    }
}
