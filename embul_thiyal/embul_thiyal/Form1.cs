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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            frm_sale sale = new frm_sale();
            sale.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            frm_customer customer = new frm_customer();
            customer.Show();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            frm_item item = new frm_item();
            item.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            frm_dashboard dashboard = new frm_dashboard();
            dashboard.Show();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            //frm_ sale = new frm_sale();
            //this.Hide();
            //sale.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            this.Hide();
            login.Show();   
        }

        private void btn_purchasing_Click(object sender, EventArgs e)
        {
            frm_purchasing purchasing = new frm_purchasing();
            this.Hide();
            purchasing.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            frm_stock stock = new frm_stock();
            this.Hide();
            stock.Show();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {

        }
    }
}
