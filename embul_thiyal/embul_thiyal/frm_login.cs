using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace embul_thiyal
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();

            string username, password;

            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                string qry = "select * from user where username = '" + txt_username.Text + "'AND password = '" + txt_password.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(qry, cls_connection.con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;


                    DateTime dt1 = DateTime.Now;
                    DateTime dt2 = DateTime.Parse("01/01/2024");

                    int dataDiff = ((TimeSpan)(dt2 - dt1)).Days;
                    MessageBox.Show("Welcome.You have " + dataDiff + " days to expire the software");
                    // string username = dt.Rows[0][5].ToString();
                    frm_home db = new frm_home();
                    this.Hide();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void login()
        {
            cls_connection.open_connection();

            MySqlCommand cmd = new MySqlCommand("select * from user where (username,password ) values(@username,@password)", cls_connection.con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Parse("01/01/2024");

                int dataDiff = ((TimeSpan)(dt2 - dt1)).Days;
                MessageBox.Show("Welcome.You have " + dataDiff + " days to expire the software");
                string username = dt.Rows[0][5].ToString();
                frm_home db = new frm_home();
                this.Hide();
                db.Show();

            }
            else
            {
                MessageBox.Show("Check again");
            }

            cls_connection.close_connection();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            //DateTime dt1 = DateTime.Now;
            //DateTime dt2 = DateTime.Parse("01/01/2024");

            //int dataDiff = ((TimeSpan)(dt2 - dt1)).Days;

            //if (dataDiff < 0)
            //{
            //    frm_licence lice = new frm_licence();
            //    this.Hide();
            //    lice.Show();

            //}
        }
    }
}
