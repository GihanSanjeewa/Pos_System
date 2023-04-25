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
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_home home = new frm_home();
            this.Hide();
            home.Show();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `invoice_num`, `invoice_date`, `amount` FROM `sale` WHERE `invoice_date` BETWEEN @d1 AND @d2 ", cls_connection.con);


            cmd.Parameters.Add("@d1", MySqlDbType.Date).Value = dtp_start.Value;
            cmd.Parameters.Add("@d2", MySqlDbType.Date).Value = dtp_end.Value;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            colTot();
        }
        private void colTot()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            lbl_tot.Text = sum.ToString();
        }
    }
}
