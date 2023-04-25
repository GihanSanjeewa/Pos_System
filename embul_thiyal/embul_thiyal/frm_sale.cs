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

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

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

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add2Bill_Click(object sender, EventArgs e)
        {
            if (lbl_item1.Text == "")
            {

                lbl_item1.Text = txt_iName.Text;
                lbl_unitPrice1.Text = txt_uPrice.Text;
                lbl_qty1.Text = txt_quantity.Text;
                lbl_tot1.Text = (Convert.ToInt32(lbl_unitPrice1.Text) * Convert.ToInt32(lbl_qty1.Text)).ToString();

            }


            else if (lbl_item2.Text == "")
            {
                lbl_item2.Text = txt_iName.Text;
                lbl_unitPrice2.Text = txt_uPrice.Text;
                lbl_qty2.Text = txt_quantity.Text;
                lbl_tot2.Text = (Convert.ToInt32(lbl_unitPrice2.Text) * Convert.ToInt32(lbl_qty2.Text)).ToString();
            }

            else if (lbl_item3.Text == "")
            {
                lbl_item3.Text = txt_iName.Text;
                lbl_unitPrice3.Text = txt_uPrice.Text;
                lbl_qty3.Text = txt_quantity.Text;
                lbl_tot3.Text = (Convert.ToInt32(lbl_unitPrice3.Text) * Convert.ToInt32(lbl_qty3.Text)).ToString();
            }

            else if (lbl_item4.Text == "")
            {
                lbl_item4.Text = txt_iName.Text;
                lbl_unitPrice4.Text = txt_uPrice.Text;
                lbl_qty4.Text = txt_quantity.Text;
                lbl_tot4.Text = (Convert.ToInt32(lbl_unitPrice4.Text) * Convert.ToInt32(lbl_qty4.Text)).ToString();
            }
            else
            {
                lbl_item5.Text = txt_iName.Text;
                lbl_unitPrice5.Text = txt_uPrice.Text;
                lbl_qty5.Text = txt_quantity.Text;
                lbl_tot5.Text = (Convert.ToInt32(lbl_unitPrice5.Text) * Convert.ToInt32(lbl_qty5.Text)).ToString();
            }





            //    if (lbl_tot5.Text == "")
            //        {
            //            if (lbl_tot4.Text == "")
            //            {
            //                if (lbl_tot3.Text == "")
            //                {
            //                    if (lbl_tot2.Text == "")
            //                    {
            //                        if (lbl_tot1.Text == "")
            //                        {
            //                            lbl_total.Text = "0";
            //                        }
            //                        else
            //                        {
            //                            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text)).ToString();

            //                        }
            //                    }
            //                    else
            //                    {
            //                        lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text)).ToString();

            //                    }

            //                }

            //                else
            //                {
            //                    lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text)).ToString();
            //                }


            //            }

            //            else
            //            {
            //                lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();

            //            }

            //        }

            //        else
            //        {
            //            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text) + Convert.ToInt32(lbl_tot5.Text)).ToString();

            //        }


            //    //  lbl_tot1.Text = Convert.ToInt32( txt_iName.Text);

            //    //  lbl_item2.Text = txt_iName.Text;
            //    //  lbl_unitPrice.Text = txt_uPrice.Text;
            //    //  lbl_qty1.Text = txt_quantity.Text;
            //
        }
    }
}
