
namespace embul_thiyal
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_backup = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_item = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sale = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_date = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 647);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase/Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(943, 647);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage \r\nItems";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1208, 647);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dashboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1500, 647);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 647);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manage \r\nCustomer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.lbl_date);
            this.guna2Panel1.Controls.Add(this.lbl_time);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1800, 413);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Logout";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
            this.btn_logout.Image = global::embul_thiyal.Properties.Resources.logout;
            this.btn_logout.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_logout.Location = new System.Drawing.Point(15, 13);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(56, 52);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_backup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_backup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_backup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_backup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_backup.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_backup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Image = global::embul_thiyal.Properties.Resources.editing;
            this.btn_backup.ImageSize = new System.Drawing.Size(100, 100);
            this.btn_backup.Location = new System.Drawing.Point(1443, 474);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(175, 150);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::embul_thiyal.Properties.Resources.speedometer;
            this.btn_dashboard.ImageSize = new System.Drawing.Size(100, 100);
            this.btn_dashboard.Location = new System.Drawing.Point(1176, 474);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(175, 150);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_item
            // 
            this.btn_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_item.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_item.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_item.ForeColor = System.Drawing.Color.White;
            this.btn_item.Image = global::embul_thiyal.Properties.Resources.shopping_bag;
            this.btn_item.ImageSize = new System.Drawing.Size(100, 100);
            this.btn_item.Location = new System.Drawing.Point(915, 474);
            this.btn_item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(175, 150);
            this.btn_item.TabIndex = 0;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customer.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_customer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_customer.ForeColor = System.Drawing.Color.White;
            this.btn_customer.Image = global::embul_thiyal.Properties.Resources.customer_service;
            this.btn_customer.ImageSize = new System.Drawing.Size(100, 100);
            this.btn_customer.Location = new System.Drawing.Point(675, 474);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(175, 150);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sale.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sale.ForeColor = System.Drawing.Color.White;
            this.btn_sale.Image = global::embul_thiyal.Properties.Resources.statistics;
            this.btn_sale.ImageSize = new System.Drawing.Size(100, 100);
            this.btn_sale.Location = new System.Drawing.Point(437, 474);
            this.btn_sale.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(175, 150);
            this.btn_sale.TabIndex = 0;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_time.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_time.Location = new System.Drawing.Point(1373, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(80, 32);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "Time ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_date.Location = new System.Drawing.Point(1373, 69);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(76, 32);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date ";
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_item);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.btn_sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_sale;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_customer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_item;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_backup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_date;
    }
}

