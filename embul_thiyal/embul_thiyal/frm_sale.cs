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
using System.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace embul_thiyal
{
    public partial class frm_sale : Form
    {
        public frm_sale()
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

        private void frm_sale_Load(object sender, EventArgs e)
        {
            //MySqlDataAdapter da = new MySqlDataAdapter("select * from item", cls_connection.con);

            //DataTable dt = new DataTable();

            //da.Fill(dt);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{


            //    txt_search.Add(dt.Rows[i]["item_name"]);

            //}
            fndataLoad();

        }
        public void fndataLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item.DataSource = ds.Tables["item"].DefaultView;

            cls_connection.close_connection();

        }

        private void cb_loyaltyPoints_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_loyaltyPoints.Checked == true)
            {
                lbl_availblePoints.Enabled = true;
                lbl_phoneNumber.Enabled = true;
                txt_mobileNumber.Enabled = true;

            }
            else
            {
                lbl_availblePoints.Enabled = false;
                lbl_phoneNumber.Enabled = false;
                txt_mobileNumber.Enabled = false;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            cls_connection.open_connection();
            MySqlCommand cmd = new MySqlCommand(" SELECT `item_id`,`item_name`,`item_price`,`category` FROM `item` WHERE item_name like '%" + txt_search.Text + "%' ", cls_connection.con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv_item.DataSource = dt;
            


            cls_connection.close_connection();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd1 = new MySqlCommand("SELECT `item_id`,`item_name`,`item_price` FROM `item` WHERE item_id =@id", cls_connection.con);
            cls_connection.open_connection();
            cmd1.Parameters.AddWithValue("id", txt_itemCode.Text);

            MySqlDataReader reader1 = cmd1.ExecuteReader();


            

            if (reader1.Read())
            {
                
                

                    // txt_itemCode.Text = reader1["item_id"].ToString();


                    txt_uPrice.Text = reader1["item_price"].ToString();
                    txt_iName.Text = reader1["item_name"].ToString();

                



            }

            else
            {
                MessageBox.Show("No data found");
            }
            
            reader1.Close();
            cls_connection.close_connection();
        }
    }
}
