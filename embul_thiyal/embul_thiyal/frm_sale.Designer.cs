
namespace embul_thiyal
{
    partial class frm_sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sale));
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add2Bill = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.txt_iName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_select = new Guna.UI2.WinForms.Guna2Button();
            this.cb_loyaltyPoints = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_availblePoints = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mobileNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_discount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_uPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_itemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_item1 = new System.Windows.Forms.Label();
            this.lbl_qty1 = new System.Windows.Forms.Label();
            this.lbl_unitPrice1 = new System.Windows.Forms.Label();
            this.lbl_tot1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_remove5 = new System.Windows.Forms.Button();
            this.btn_remove4 = new System.Windows.Forms.Button();
            this.btn_remove3 = new System.Windows.Forms.Button();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.btn_remove1 = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_tot5 = new System.Windows.Forms.Label();
            this.lbl_tot4 = new System.Windows.Forms.Label();
            this.lbl_tot3 = new System.Windows.Forms.Label();
            this.lbl_tot2 = new System.Windows.Forms.Label();
            this.lbl_unitPrice5 = new System.Windows.Forms.Label();
            this.lbl_unitPrice4 = new System.Windows.Forms.Label();
            this.lbl_unitPrice3 = new System.Windows.Forms.Label();
            this.lbl_unitPrice2 = new System.Windows.Forms.Label();
            this.lbl_qty5 = new System.Windows.Forms.Label();
            this.lbl_qty4 = new System.Windows.Forms.Label();
            this.lbl_qty3 = new System.Windows.Forms.Label();
            this.lbl_qty2 = new System.Windows.Forms.Label();
            this.lbl_item5 = new System.Windows.Forms.Label();
            this.lbl_item4 = new System.Windows.Forms.Label();
            this.lbl_item3 = new System.Windows.Forms.Label();
            this.lbl_item2 = new System.Windows.Forms.Label();
            this.btn_process = new Guna.UI2.WinForms.Guna2Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1721, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Home";
            // 
            // btn_add2Bill
            // 
            this.btn_add2Bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add2Bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add2Bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add2Bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add2Bill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add2Bill.ForeColor = System.Drawing.Color.White;
            this.btn_add2Bill.Location = new System.Drawing.Point(140, 549);
            this.btn_add2Bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add2Bill.Name = "btn_add2Bill";
            this.btn_add2Bill.Size = new System.Drawing.Size(180, 46);
            this.btn_add2Bill.TabIndex = 8;
            this.btn_add2Bill.Text = "Add item";
            this.btn_add2Bill.Click += new System.EventHandler(this.btn_add2Bill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgv_item);
            this.groupBox1.Controls.Add(this.txt_iName);
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.cb_loyaltyPoints);
            this.groupBox1.Controls.Add(this.lbl_phoneNumber);
            this.groupBox1.Controls.Add(this.lbl_availblePoints);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_mobileNumber);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.txt_discount);
            this.groupBox1.Controls.Add(this.txt_uPrice);
            this.groupBox1.Controls.Add(this.txt_itemCode);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.btn_add2Bill);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(635, 825);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 777);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Discount";
            // 
            // dgv_item
            // 
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(19, 148);
            this.dgv_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.RowHeadersWidth = 51;
            this.dgv_item.RowTemplate.Height = 24;
            this.dgv_item.Size = new System.Drawing.Size(597, 272);
            this.dgv_item.TabIndex = 15;
            // 
            // txt_iName
            // 
            this.txt_iName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_iName.DefaultText = "";
            this.txt_iName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_iName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_iName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_iName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_iName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_iName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_iName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_iName.Location = new System.Drawing.Point(140, 441);
            this.txt_iName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_iName.Name = "txt_iName";
            this.txt_iName.PasswordChar = '\0';
            this.txt_iName.PlaceholderText = "";
            this.txt_iName.SelectedText = "";
            this.txt_iName.Size = new System.Drawing.Size(244, 32);
            this.txt_iName.TabIndex = 14;
            // 
            // btn_select
            // 
            this.btn_select.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_select.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_select.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_select.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_select.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(412, 94);
            this.btn_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(129, 39);
            this.btn_select.TabIndex = 13;
            this.btn_select.Text = "Select";
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cb_loyaltyPoints
            // 
            this.cb_loyaltyPoints.AutoSize = true;
            this.cb_loyaltyPoints.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_loyaltyPoints.CheckedState.BorderRadius = 0;
            this.cb_loyaltyPoints.CheckedState.BorderThickness = 0;
            this.cb_loyaltyPoints.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_loyaltyPoints.Location = new System.Drawing.Point(124, 671);
            this.cb_loyaltyPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_loyaltyPoints.Name = "cb_loyaltyPoints";
            this.cb_loyaltyPoints.Size = new System.Drawing.Size(101, 20);
            this.cb_loyaltyPoints.TabIndex = 12;
            this.cb_loyaltyPoints.Text = "Loyal points";
            this.cb_loyaltyPoints.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_loyaltyPoints.UncheckedState.BorderRadius = 0;
            this.cb_loyaltyPoints.UncheckedState.BorderThickness = 0;
            this.cb_loyaltyPoints.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_loyaltyPoints.CheckedChanged += new System.EventHandler(this.cb_loyaltyPoints_CheckedChanged);
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Enabled = false;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(15, 727);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(94, 16);
            this.lbl_phoneNumber.TabIndex = 10;
            this.lbl_phoneNumber.Text = "Phone number";
            // 
            // lbl_availblePoints
            // 
            this.lbl_availblePoints.AutoSize = true;
            this.lbl_availblePoints.Enabled = false;
            this.lbl_availblePoints.Location = new System.Drawing.Point(404, 729);
            this.lbl_availblePoints.Name = "lbl_availblePoints";
            this.lbl_availblePoints.Size = new System.Drawing.Size(103, 16);
            this.lbl_availblePoints.TabIndex = 10;
            this.lbl_availblePoints.Text = "Available points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantitiy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item name";
            // 
            // txt_mobileNumber
            // 
            this.txt_mobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mobileNumber.DefaultText = "";
            this.txt_mobileNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mobileNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mobileNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mobileNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mobileNumber.Enabled = false;
            this.txt_mobileNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mobileNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mobileNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mobileNumber.Location = new System.Drawing.Point(140, 721);
            this.txt_mobileNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mobileNumber.Name = "txt_mobileNumber";
            this.txt_mobileNumber.PasswordChar = '\0';
            this.txt_mobileNumber.PlaceholderText = "";
            this.txt_mobileNumber.SelectedText = "";
            this.txt_mobileNumber.Size = new System.Drawing.Size(244, 32);
            this.txt_mobileNumber.TabIndex = 9;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantity.DefaultText = "";
            this.txt_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Location = new System.Drawing.Point(140, 486);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.PlaceholderText = "";
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.Size = new System.Drawing.Size(101, 32);
            this.txt_quantity.TabIndex = 9;
            // 
            // txt_discount
            // 
            this.txt_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_discount.DefaultText = "";
            this.txt_discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_discount.Location = new System.Drawing.Point(140, 761);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.PasswordChar = '\0';
            this.txt_discount.PlaceholderText = "";
            this.txt_discount.SelectedText = "";
            this.txt_discount.Size = new System.Drawing.Size(124, 32);
            this.txt_discount.TabIndex = 9;
            // 
            // txt_uPrice
            // 
            this.txt_uPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_uPrice.DefaultText = "";
            this.txt_uPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_uPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_uPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_uPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_uPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_uPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_uPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_uPrice.Location = new System.Drawing.Point(363, 486);
            this.txt_uPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_uPrice.Name = "txt_uPrice";
            this.txt_uPrice.PasswordChar = '\0';
            this.txt_uPrice.PlaceholderText = "";
            this.txt_uPrice.SelectedText = "";
            this.txt_uPrice.Size = new System.Drawing.Size(124, 32);
            this.txt_uPrice.TabIndex = 9;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemCode.DefaultText = "";
            this.txt_itemCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_itemCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_itemCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_itemCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemCode.Location = new System.Drawing.Point(140, 96);
            this.txt_itemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.PasswordChar = '\0';
            this.txt_itemCode.PlaceholderText = "";
            this.txt_itemCode.SelectedText = "";
            this.txt_itemCode.Size = new System.Drawing.Size(244, 32);
            this.txt_itemCode.TabIndex = 9;
            this.txt_itemCode.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(140, 31);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(244, 32);
            this.txt_search.TabIndex = 9;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::embul_thiyal.Properties.Resources.house;
            this.guna2Button5.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button5.Location = new System.Drawing.Point(1715, 14);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(72, 73);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click_1);
            // 
            // lbl_item1
            // 
            this.lbl_item1.AutoSize = true;
            this.lbl_item1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_item1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_item1.Location = new System.Drawing.Point(41, 135);
            this.lbl_item1.Name = "lbl_item1";
            this.lbl_item1.Size = new System.Drawing.Size(0, 16);
            this.lbl_item1.TabIndex = 10;
            // 
            // lbl_qty1
            // 
            this.lbl_qty1.AutoSize = true;
            this.lbl_qty1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_qty1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qty1.Location = new System.Drawing.Point(256, 135);
            this.lbl_qty1.Name = "lbl_qty1";
            this.lbl_qty1.Size = new System.Drawing.Size(0, 16);
            this.lbl_qty1.TabIndex = 10;
            // 
            // lbl_unitPrice1
            // 
            this.lbl_unitPrice1.AutoSize = true;
            this.lbl_unitPrice1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_unitPrice1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_unitPrice1.Location = new System.Drawing.Point(145, 135);
            this.lbl_unitPrice1.Name = "lbl_unitPrice1";
            this.lbl_unitPrice1.Size = new System.Drawing.Size(0, 16);
            this.lbl_unitPrice1.TabIndex = 10;
            // 
            // lbl_tot1
            // 
            this.lbl_tot1.AutoSize = true;
            this.lbl_tot1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tot1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tot1.Location = new System.Drawing.Point(351, 135);
            this.lbl_tot1.Name = "lbl_tot1";
            this.lbl_tot1.Size = new System.Drawing.Size(0, 16);
            this.lbl_tot1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Embul thiyal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_process);
            this.panel1.Controls.Add(this.btn_remove5);
            this.panel1.Controls.Add(this.btn_remove4);
            this.panel1.Controls.Add(this.btn_remove3);
            this.panel1.Controls.Add(this.btn_remove2);
            this.panel1.Controls.Add(this.btn_remove1);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_tot5);
            this.panel1.Controls.Add(this.lbl_tot4);
            this.panel1.Controls.Add(this.lbl_tot3);
            this.panel1.Controls.Add(this.lbl_tot2);
            this.panel1.Controls.Add(this.lbl_tot1);
            this.panel1.Controls.Add(this.lbl_unitPrice5);
            this.panel1.Controls.Add(this.lbl_unitPrice4);
            this.panel1.Controls.Add(this.lbl_unitPrice3);
            this.panel1.Controls.Add(this.lbl_unitPrice2);
            this.panel1.Controls.Add(this.lbl_unitPrice1);
            this.panel1.Controls.Add(this.lbl_qty5);
            this.panel1.Controls.Add(this.lbl_qty4);
            this.panel1.Controls.Add(this.lbl_qty3);
            this.panel1.Controls.Add(this.lbl_qty2);
            this.panel1.Controls.Add(this.lbl_qty1);
            this.panel1.Controls.Add(this.lbl_item5);
            this.panel1.Controls.Add(this.lbl_item4);
            this.panel1.Controls.Add(this.lbl_item3);
            this.panel1.Controls.Add(this.lbl_item2);
            this.panel1.Controls.Add(this.lbl_item1);
            this.panel1.Location = new System.Drawing.Point(776, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 811);
            this.panel1.TabIndex = 10;
            // 
            // btn_remove5
            // 
            this.btn_remove5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove5.Location = new System.Drawing.Point(415, 283);
            this.btn_remove5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove5.Name = "btn_remove5";
            this.btn_remove5.Size = new System.Drawing.Size(43, 31);
            this.btn_remove5.TabIndex = 11;
            this.btn_remove5.Text = "-";
            this.btn_remove5.UseVisualStyleBackColor = true;
            this.btn_remove5.Visible = false;
            this.btn_remove5.Click += new System.EventHandler(this.btn_remove5_Click);
            // 
            // btn_remove4
            // 
            this.btn_remove4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove4.Location = new System.Drawing.Point(415, 242);
            this.btn_remove4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove4.Name = "btn_remove4";
            this.btn_remove4.Size = new System.Drawing.Size(43, 31);
            this.btn_remove4.TabIndex = 11;
            this.btn_remove4.Text = "-";
            this.btn_remove4.UseVisualStyleBackColor = true;
            this.btn_remove4.Visible = false;
            this.btn_remove4.Click += new System.EventHandler(this.btn_remove4_Click);
            // 
            // btn_remove3
            // 
            this.btn_remove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove3.Location = new System.Drawing.Point(415, 197);
            this.btn_remove3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove3.Name = "btn_remove3";
            this.btn_remove3.Size = new System.Drawing.Size(43, 31);
            this.btn_remove3.TabIndex = 11;
            this.btn_remove3.Text = "-";
            this.btn_remove3.UseVisualStyleBackColor = true;
            this.btn_remove3.Visible = false;
            this.btn_remove3.Click += new System.EventHandler(this.btn_remove3_Click);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove2.Location = new System.Drawing.Point(415, 156);
            this.btn_remove2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(43, 31);
            this.btn_remove2.TabIndex = 11;
            this.btn_remove2.Text = "-";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Visible = false;
            this.btn_remove2.Click += new System.EventHandler(this.btn_remove2_Click);
            // 
            // btn_remove1
            // 
            this.btn_remove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove1.Location = new System.Drawing.Point(415, 121);
            this.btn_remove1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove1.Name = "btn_remove1";
            this.btn_remove1.Size = new System.Drawing.Size(43, 31);
            this.btn_remove1.TabIndex = 11;
            this.btn_remove1.Text = "-";
            this.btn_remove1.UseVisualStyleBackColor = true;
            this.btn_remove1.Visible = false;
            this.btn_remove1.Click += new System.EventHandler(this.btn_remove1_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(209, 436);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(61, 25);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total";
            // 
            // lbl_tot5
            // 
            this.lbl_tot5.AutoSize = true;
            this.lbl_tot5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tot5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tot5.Location = new System.Drawing.Point(351, 292);
            this.lbl_tot5.Name = "lbl_tot5";
            this.lbl_tot5.Size = new System.Drawing.Size(0, 16);
            this.lbl_tot5.TabIndex = 10;
            // 
            // lbl_tot4
            // 
            this.lbl_tot4.AutoSize = true;
            this.lbl_tot4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tot4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tot4.Location = new System.Drawing.Point(351, 251);
            this.lbl_tot4.Name = "lbl_tot4";
            this.lbl_tot4.Size = new System.Drawing.Size(0, 16);
            this.lbl_tot4.TabIndex = 10;
            // 
            // lbl_tot3
            // 
            this.lbl_tot3.AutoSize = true;
            this.lbl_tot3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tot3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tot3.Location = new System.Drawing.Point(351, 212);
            this.lbl_tot3.Name = "lbl_tot3";
            this.lbl_tot3.Size = new System.Drawing.Size(0, 16);
            this.lbl_tot3.TabIndex = 10;
            // 
            // lbl_tot2
            // 
            this.lbl_tot2.AutoSize = true;
            this.lbl_tot2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tot2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tot2.Location = new System.Drawing.Point(351, 171);
            this.lbl_tot2.Name = "lbl_tot2";
            this.lbl_tot2.Size = new System.Drawing.Size(0, 16);
            this.lbl_tot2.TabIndex = 10;
            // 
            // lbl_unitPrice5
            // 
            this.lbl_unitPrice5.AutoSize = true;
            this.lbl_unitPrice5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_unitPrice5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_unitPrice5.Location = new System.Drawing.Point(145, 292);
            this.lbl_unitPrice5.Name = "lbl_unitPrice5";
            this.lbl_unitPrice5.Size = new System.Drawing.Size(0, 16);
            this.lbl_unitPrice5.TabIndex = 10;
            // 
            // lbl_unitPrice4
            // 
            this.lbl_unitPrice4.AutoSize = true;
            this.lbl_unitPrice4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_unitPrice4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_unitPrice4.Location = new System.Drawing.Point(145, 251);
            this.lbl_unitPrice4.Name = "lbl_unitPrice4";
            this.lbl_unitPrice4.Size = new System.Drawing.Size(0, 16);
            this.lbl_unitPrice4.TabIndex = 10;
            // 
            // lbl_unitPrice3
            // 
            this.lbl_unitPrice3.AutoSize = true;
            this.lbl_unitPrice3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_unitPrice3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_unitPrice3.Location = new System.Drawing.Point(145, 212);
            this.lbl_unitPrice3.Name = "lbl_unitPrice3";
            this.lbl_unitPrice3.Size = new System.Drawing.Size(0, 16);
            this.lbl_unitPrice3.TabIndex = 10;
            // 
            // lbl_unitPrice2
            // 
            this.lbl_unitPrice2.AutoSize = true;
            this.lbl_unitPrice2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_unitPrice2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_unitPrice2.Location = new System.Drawing.Point(145, 171);
            this.lbl_unitPrice2.Name = "lbl_unitPrice2";
            this.lbl_unitPrice2.Size = new System.Drawing.Size(0, 16);
            this.lbl_unitPrice2.TabIndex = 10;
            // 
            // lbl_qty5
            // 
            this.lbl_qty5.AutoSize = true;
            this.lbl_qty5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_qty5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qty5.Location = new System.Drawing.Point(256, 292);
            this.lbl_qty5.Name = "lbl_qty5";
            this.lbl_qty5.Size = new System.Drawing.Size(0, 16);
            this.lbl_qty5.TabIndex = 10;
            // 
            // lbl_qty4
            // 
            this.lbl_qty4.AutoSize = true;
            this.lbl_qty4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_qty4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qty4.Location = new System.Drawing.Point(256, 251);
            this.lbl_qty4.Name = "lbl_qty4";
            this.lbl_qty4.Size = new System.Drawing.Size(0, 16);
            this.lbl_qty4.TabIndex = 10;
            // 
            // lbl_qty3
            // 
            this.lbl_qty3.AutoSize = true;
            this.lbl_qty3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_qty3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qty3.Location = new System.Drawing.Point(256, 212);
            this.lbl_qty3.Name = "lbl_qty3";
            this.lbl_qty3.Size = new System.Drawing.Size(0, 16);
            this.lbl_qty3.TabIndex = 10;
            // 
            // lbl_qty2
            // 
            this.lbl_qty2.AutoSize = true;
            this.lbl_qty2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_qty2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qty2.Location = new System.Drawing.Point(256, 171);
            this.lbl_qty2.Name = "lbl_qty2";
            this.lbl_qty2.Size = new System.Drawing.Size(0, 16);
            this.lbl_qty2.TabIndex = 10;
            // 
            // lbl_item5
            // 
            this.lbl_item5.AutoSize = true;
            this.lbl_item5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_item5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_item5.Location = new System.Drawing.Point(41, 292);
            this.lbl_item5.Name = "lbl_item5";
            this.lbl_item5.Size = new System.Drawing.Size(0, 16);
            this.lbl_item5.TabIndex = 10;
            // 
            // lbl_item4
            // 
            this.lbl_item4.AutoSize = true;
            this.lbl_item4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_item4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_item4.Location = new System.Drawing.Point(41, 251);
            this.lbl_item4.Name = "lbl_item4";
            this.lbl_item4.Size = new System.Drawing.Size(0, 16);
            this.lbl_item4.TabIndex = 10;
            // 
            // lbl_item3
            // 
            this.lbl_item3.AutoSize = true;
            this.lbl_item3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_item3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_item3.Location = new System.Drawing.Point(41, 212);
            this.lbl_item3.Name = "lbl_item3";
            this.lbl_item3.Size = new System.Drawing.Size(0, 16);
            this.lbl_item3.TabIndex = 10;
            // 
            // lbl_item2
            // 
            this.lbl_item2.AutoSize = true;
            this.lbl_item2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_item2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_item2.Location = new System.Drawing.Point(41, 171);
            this.lbl_item2.Name = "lbl_item2";
            this.lbl_item2.Size = new System.Drawing.Size(0, 16);
            this.lbl_item2.TabIndex = 10;
            // 
            // btn_process
            // 
            this.btn_process.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_process.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_process.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_process.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_process.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_process.ForeColor = System.Drawing.Color.White;
            this.btn_process.Location = new System.Drawing.Point(295, 524);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(180, 45);
            this.btn_process.TabIndex = 12;
            this.btn_process.Text = "Process";
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frm_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frm_sale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btn_add2Bill;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox cb_loyaltyPoints;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.Label lbl_availblePoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_mobileNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_uPrice;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_itemCode;
        private Guna.UI2.WinForms.Guna2Button btn_select;
        private Guna.UI2.WinForms.Guna2TextBox txt_iName;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_discount;
        private System.Windows.Forms.Label lbl_item1;
        private System.Windows.Forms.Label lbl_qty1;
        private System.Windows.Forms.Label lbl_unitPrice1;
        private System.Windows.Forms.Label lbl_tot1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tot5;
        private System.Windows.Forms.Label lbl_tot4;
        private System.Windows.Forms.Label lbl_tot3;
        private System.Windows.Forms.Label lbl_tot2;
        private System.Windows.Forms.Label lbl_unitPrice5;
        private System.Windows.Forms.Label lbl_unitPrice4;
        private System.Windows.Forms.Label lbl_unitPrice3;
        private System.Windows.Forms.Label lbl_unitPrice2;
        private System.Windows.Forms.Label lbl_qty5;
        private System.Windows.Forms.Label lbl_qty4;
        private System.Windows.Forms.Label lbl_qty3;
        private System.Windows.Forms.Label lbl_qty2;
        private System.Windows.Forms.Label lbl_item5;
        private System.Windows.Forms.Label lbl_item4;
        private System.Windows.Forms.Label lbl_item3;
        private System.Windows.Forms.Label lbl_item2;
        private System.Windows.Forms.Button btn_remove5;
        private System.Windows.Forms.Button btn_remove4;
        private System.Windows.Forms.Button btn_remove3;
        private System.Windows.Forms.Button btn_remove2;
        private System.Windows.Forms.Button btn_remove1;
        private System.Windows.Forms.Label lbl_total;
        private Guna.UI2.WinForms.Guna2Button btn_process;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}