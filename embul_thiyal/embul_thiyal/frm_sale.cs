using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

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
            //cls_connection.open_connection();
            //MySqlCommand cmd = new MySqlCommand(" SELECT `item_id`,`item_name`,`item_price`,`category` FROM `item` WHERE item_name like '%" + txt_search.Text + "%' ", cls_connection.con);
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.SelectCommand = cmd;
            //dt.Clear();
            //da.Fill(dt);
            //dgv_item.DataSource = dt;
            


            //cls_connection.close_connection();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd1 = new MySqlCommand("SELECT `item_id`,`item_name`,`item_price` FROM `item`", cls_connection.con);
            cls_connection.open_connection();
           // cmd1.Parameters.AddWithValue();

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
        private void process1()
        {
            lbl_item1.Text = txt_iName.Text;
            lbl_unitPrice1.Text = txt_uPrice.Text;
            lbl_qty1.Text = txt_quantity.Text;
            lbl_tot1.Text = (Convert.ToInt32(lbl_unitPrice1.Text) * Convert.ToInt32(lbl_qty1.Text)).ToString();

            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text)).ToString();
        }
        private void process2()
        {
            lbl_item2.Text = txt_iName.Text;
            lbl_unitPrice2.Text = txt_uPrice.Text;
            lbl_qty2.Text = txt_quantity.Text;
            lbl_tot2.Text = (Convert.ToInt32(lbl_unitPrice2.Text) * Convert.ToInt32(lbl_qty2.Text)).ToString();

            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text)).ToString();
        }
        private void process3()
        {
            lbl_item3.Text = txt_iName.Text;
            lbl_unitPrice3.Text = txt_uPrice.Text;
            lbl_qty3.Text = txt_quantity.Text;
            lbl_tot3.Text = (Convert.ToInt32(lbl_unitPrice3.Text) * Convert.ToInt32(lbl_qty3.Text)).ToString();

            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text)).ToString();
        }
        private void process4()
        {
            lbl_item4.Text = txt_iName.Text;
            lbl_unitPrice4.Text = txt_uPrice.Text;
            lbl_qty4.Text = txt_quantity.Text;
            lbl_tot4.Text = (Convert.ToInt32(lbl_unitPrice4.Text) * Convert.ToInt32(lbl_qty4.Text)).ToString();

            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();
        }
        private void process5()
        {
            lbl_item5.Text = txt_iName.Text;
            lbl_unitPrice5.Text = txt_uPrice.Text;
            lbl_qty5.Text = txt_quantity.Text;
            lbl_tot5.Text = (Convert.ToInt32(lbl_unitPrice5.Text) * Convert.ToInt32(lbl_qty5.Text)).ToString();

            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text) + Convert.ToInt32(lbl_tot5.Text)).ToString();
        }

        private void billTot()
        {

            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text)+ Convert.ToInt32(lbl_tot3.Text)+ Convert.ToInt32(lbl_tot4.Text)+ Convert.ToInt32(lbl_tot5.Text)).ToString();
        }

        private void btn_add2Bill_Click(object sender, EventArgs e)
        {
            if (lbl_item1.Text == "")
            {
                process1();
                btn_remove1.Visible = true;
               


            }
            else if (lbl_item2.Text == "")
            {
                process2();
                btn_remove2.Visible = true;



            }

            else if (lbl_item3.Text == "")
            {
                process3();
                btn_remove3.Visible = true;



            }

            else if (lbl_item4.Text == "")
            {
                process4();
                btn_remove4.Visible = true;

            }
            else
            {
                process5();
                btn_remove5.Visible = true;


            }





        }
        private void clear5()
        {
            lbl_item5.Text = "";
            lbl_qty5.Text = "";
            lbl_tot5.Text = "";
            lbl_unitPrice5.Text = "";
            btn_remove5.Visible = false;
        }
        private void clear4()
        {
            lbl_item4.Text = "";
            lbl_qty4.Text = "";
            lbl_tot4.Text = "";
            lbl_unitPrice4.Text = "";
            btn_remove4.Visible = false;
        }
        private void clear3()
        {
            lbl_item3.Text = "";
            lbl_qty3.Text = "";
            lbl_tot3.Text = "";
            lbl_unitPrice3.Text = "";
            btn_remove3.Visible = false;

        }
        private void clear2()
        {

            lbl_item2.Text = "";
            lbl_qty2.Text = "";
            lbl_tot2.Text = "";
            lbl_unitPrice2.Text = "";
            btn_remove2.Visible = false;

        }
        private void clear1()
        {
            lbl_item1.Text = "";
            lbl_qty1.Text = "";
            lbl_tot1.Text = "";
            lbl_unitPrice1.Text = "";
            btn_remove1.Visible = false;
        }

        private void btn_remove5_Click(object sender, EventArgs e)
        {
            clear5();


            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();


        }

        private void btn_remove4_Click(object sender, EventArgs e)
        {


            if (lbl_item5.Text!= "")
            {
                //shift by 1 raw
                lbl_item4.Text =  lbl_item5.Text;
                lbl_qty4.Text = lbl_qty5.Text;
                lbl_tot4.Text = lbl_tot5.Text;
                lbl_unitPrice4.Text = lbl_unitPrice5.Text;
                btn_remove5.Visible = false;

                //clear raw 5

               clear5();

                lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();


            }
            else
            {

                clear4();
                lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text)).ToString();


            }
        }

        private void btn_remove3_Click(object sender, EventArgs e)
        {
           

            if (lbl_item4.Text != "")
            {
                //shift by 1 raw
                lbl_item3.Text = lbl_item4.Text;
                lbl_qty3.Text = lbl_qty4.Text;
                lbl_tot3.Text = lbl_tot4.Text;
                lbl_unitPrice3.Text = lbl_unitPrice4.Text;

                clear4();

                if(lbl_item5.Text != "")
                {
                    //shift by 1 raw
                    lbl_item4.Text = lbl_item5.Text;
                    lbl_qty4.Text = lbl_qty5.Text;
                    lbl_tot4.Text = lbl_tot5.Text;
                    lbl_unitPrice4.Text = lbl_unitPrice5.Text;
                    btn_remove5.Visible = false;

                    //clear raw 5

                    clear5();
                    lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();
                }
                else
                {
                    clear4();
                    lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text)).ToString();
                }    
            }
            else
            {
                clear3();
                lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text)).ToString();
            }
        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {
           

            if (lbl_item3.Text != "")
            {
                //shift by 1 raw
                lbl_item2.Text = lbl_item3.Text;
                lbl_qty2.Text = lbl_qty3.Text;
                lbl_tot2.Text = lbl_tot3.Text;
                lbl_unitPrice2.Text = lbl_unitPrice3.Text;

                clear3();

                if (lbl_item4.Text != "")
                {
                    //shift by 1 raw
                    lbl_item3.Text = lbl_item4.Text;
                    lbl_qty3.Text = lbl_qty4.Text;
                    lbl_tot3.Text = lbl_tot4.Text;
                    lbl_unitPrice3.Text = lbl_unitPrice4.Text;
                    btn_remove3.Visible = false;

                    if (lbl_item5.Text != "")
                    {
                        //shift by 1 raw
                        lbl_item4.Text = lbl_item5.Text;
                        lbl_qty4.Text = lbl_qty5.Text;
                        lbl_tot4.Text = lbl_tot5.Text;
                        lbl_unitPrice4.Text = lbl_unitPrice5.Text;
                        btn_remove5.Visible = false;

                        //clear raw 5

                        clear5();

                        lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();
                    }
                    else
                    {
                        clear4();
                        lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text)).ToString();
                    }
                }
                else
                {
                    clear3();
                    lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text)).ToString();
                }

            }
            else
            {
                clear2();
                lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text)).ToString();
            }
        }

        private void btn_remove1_Click(object sender, EventArgs e)
        {

           

            if (lbl_item2.Text != "")
            {
                //shift by 1 raw
                lbl_item1.Text = lbl_item2.Text;
                lbl_qty1.Text = lbl_qty2.Text;
                lbl_tot1.Text = lbl_tot2.Text;
                lbl_unitPrice1.Text = lbl_unitPrice2.Text;

                clear2();

                if (lbl_item3.Text != "")
                {
                    //shift by 1 raw
                    lbl_item2.Text = lbl_item3.Text;
                    lbl_qty2.Text = lbl_qty3.Text;
                    lbl_tot2.Text = lbl_tot3.Text;
                    lbl_unitPrice2.Text = lbl_unitPrice3.Text;
                    btn_remove3.Visible = false;

                    if (lbl_item4.Text != "")
                    {
                        //shift by 1 raw
                        lbl_item3.Text = lbl_item4.Text;
                        lbl_qty3.Text = lbl_qty4.Text;
                        lbl_tot3.Text = lbl_tot4.Text;
                        lbl_unitPrice3.Text = lbl_unitPrice4.Text;
                        btn_remove3.Visible = false;

                        if (lbl_item5.Text != "")
                        {
                            //shift by 1 raw
                            lbl_item4.Text = lbl_item5.Text;
                            lbl_qty4.Text = lbl_qty5.Text;
                            lbl_tot4.Text = lbl_tot5.Text;
                            lbl_unitPrice4.Text = lbl_unitPrice5.Text;
                            btn_remove5.Visible = false;

                            //clear raw 5

                            clear5();
                            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text) + Convert.ToInt32(lbl_tot4.Text)).ToString();
                        }
                        else
                        {
                            clear4();
                            lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text) + Convert.ToInt32(lbl_tot3.Text)).ToString();
                        }
                       
                    }
                    else
                    {
                        clear3();
                        lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) + Convert.ToInt32(lbl_tot2.Text)).ToString();
                    }
                  
                }
                else
                {
                    clear2();
                    lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text)).ToString();
                }
               
            }
            else
            {
                clear1();
                lbl_total.Text = "0";

            }
        }

        private void btn_process_Click(object sender, EventArgs e)

        {
            if(cb_loyaltyPoints.Checked )
            {
                lbl_total.Text = (Convert.ToInt32(lbl_tot1.Text) - Convert.ToInt32(txt_discount.Text)).ToString();
            }
            saveData();
        }
        private void printBill()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        private void saveData()
        {
            cls_connection.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `bill`( `total_price`, `mobile_number`) VALUES (@total_price,@mobile_number)", cls_connection.con);
            cmd.Parameters.Clear();


            cmd.Parameters.AddWithValue("@total_price", lbl_total.Text);
            cmd.Parameters.AddWithValue("@mobile_number", txt_mobileNumber.Text);
      


            cmd.ExecuteNonQuery();
            cls_connection.close_connection();
            MessageBox.Show("Order Added Successfully!");

            //fndataLoad();
            printBill();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Embul thiyal restaurent", new System.Drawing.Font("Arial", 26, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(200, 50));

            e.Graphics.DrawString("****************************************************************************************************************************************************************************************", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(0, 370));

            e.Graphics.DrawString("Invoice Number       -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(30, 310));
            e.Graphics.DrawString("Customer        -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(450, 310));

            e.Graphics.DrawString("****************************************************************************************************************************************************************************************", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(0, 370));

            e.Graphics.DrawString("Item 1    -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(150, 460));
            e.Graphics.DrawString("Item 2    -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(150, 490));
            e.Graphics.DrawString("Item 3    -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(150, 520));
            e.Graphics.DrawString("Item 4    -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(150, 550));
            e.Graphics.DrawString("Item 5    -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(150, 580));

            e.Graphics.DrawString("****************************************************************************************************************************************************************************************", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(0, 640));
            e.Graphics.DrawString("Total Amount      -", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(500, 670));
            e.Graphics.DrawString("****************************************************************************************************************************************************************************************", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(0, 700));

            //bill Values
            //e.Graphics.DrawString(lbl_invoiceNumber.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(250, 310));
            //e.Graphics.DrawString(lbl_cusName.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(600, 310));

            e.Graphics.DrawString(lbl_item1.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(250, 460));
            e.Graphics.DrawString(lbl_qty1.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(500, 460));
            e.Graphics.DrawString(lbl_tot1.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(650, 460));

            e.Graphics.DrawString(lbl_item2.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(250, 490));
            e.Graphics.DrawString(lbl_qty2.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(500, 490));
            e.Graphics.DrawString(lbl_tot2.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(650, 490));

            e.Graphics.DrawString(lbl_item3.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(250, 520));
            e.Graphics.DrawString(lbl_qty3.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(500, 520));
            e.Graphics.DrawString(lbl_tot3.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(650, 520));

            e.Graphics.DrawString(lbl_item4.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(250, 550));
            e.Graphics.DrawString(lbl_qty4.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(500, 550));
            e.Graphics.DrawString(lbl_tot4.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(650, 550));

            e.Graphics.DrawString(lbl_item5.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(350, 580));
            e.Graphics.DrawString(lbl_qty5.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(500, 580));
            e.Graphics.DrawString(lbl_tot5.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(650, 580));


            e.Graphics.DrawString("Rs - " + lbl_total.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Gray, new System.Drawing.Point(650, 670));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_bayit_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Bites'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_riceandcurry_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Rice And Curry'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;
            

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();

        }

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvrow = dgv_item.Rows[e.RowIndex];
                txt_iName.Text = dgvrow.Cells[1].Value.ToString();
                
                txt_uPrice.Text = dgvrow.Cells[2].Value.ToString();
               

            }
        }

        private void btn_friedRice_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Fried Rice'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_chopsyRice_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Chopsy Rice'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_dewal_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Devilled'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_kottu_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Kottu'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_Noodless_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Noodles'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_shotees_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Shorteats'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_Fried_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Fried'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_juice_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Juice'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Soups'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_stoo_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Stew'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void btn_rost_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from item where category = 'Roast'", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            dgv_item1.DataSource = ds.Tables["item"].DefaultView;
            

            dgv_item.Columns[0].Name = "Item ID";
            dgv_item.Columns[1].Name = "Iem Name";
            dgv_item.Columns[2].Name = "Item Price";
            dgv_item.Columns[0].Name = "Item Category";

            cls_connection.close_connection();
        }

        private void dgv_item1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_item1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvrow = dgv_item.Rows[e.RowIndex];
                txt_iName.Text = dgvrow.Cells[1].Value.ToString();
                txt_uPrice.Text = dgvrow.Cells[2].Value.ToString();
              

            }
        }
    }
}
