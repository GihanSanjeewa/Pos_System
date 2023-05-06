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
    public partial class frm_item : Form
    {
        public frm_item()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cls_connection.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `item`( `item_name`, `item_price`, `category`) VALUES( @txt_itemName, @txt_unitPrice, @cmb_category)", cls_connection.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_itemName", txt_itemName.Text);
            cmd.Parameters.AddWithValue("@txt_unitPrice", txt_unitPrice.Text);
            cmd.Parameters.AddWithValue("@cmb_category", cmb_category.Text);

            cmd.ExecuteNonQuery();
            cls_connection.close_connection();

            MessageBox.Show("Item Added Successfully!");
            fndataLoad();
        }

        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item.DataSource = ds.Tables["item"].DefaultView;

        }
        public void addtoStock()
        {
            cls_connection.open_connection();
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `stock`(`item_name`, `quantity`, `unit_price`) VALUES( @item_name,@quantity ,@unit_price'))", cls_connection.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@item_name", txt_itemName.Text);
            cmd.Parameters.AddWithValue("@quantity",0);
            cmd.Parameters.AddWithValue("@unit_price", txt_unitPrice.Text);

            cmd.ExecuteNonQuery();
            cls_connection.close_connection();

            MessageBox.Show("Item Added Successfully!");
            fndataLoad();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //    cls_connection.open_connection();
            //    MySqlCommand cmd1 = new MySqlCommand("SELECT `item_id`,`item_name`,`item_price`,`quantity`,`category` FROM `item` WHERE item_id =@id", cls_connection.con);
            //    cmd1.Parameters.AddWithValue("id", txt_searchName.Text);

            //    MySqlDataReader reader1;
            //    reader1 = cmd1.ExecuteReader();

            //    if (reader1.Read())
            //    {
            //        txt_itemCode.Text = reader1["item_code"].ToString();
            //        txt_itemName.Text = reader1["item_name"].ToString();
            //        txt_Category.Text = reader1["category"].ToString();
            //        txt_manufacturer.Text = reader1["manufacturer"].ToString();
            //        txt_capacity.Text = reader1["capacity"].ToString();
            //        txt_unitprice.Text = reader1["unit_price"].ToString();
            //        txt_sellingPrice.Text = reader1["selling_price"].ToString();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No data found");
            //    }
            //    cls_connection.close_connection();

        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            frm_editItem editItem = new frm_editItem();
            this.Hide();
            editItem.Show();

        }

        private void frm_item_Load(object sender, EventArgs e)
        {

        }
    }
}
