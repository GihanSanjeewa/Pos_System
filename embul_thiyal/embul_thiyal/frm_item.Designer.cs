
namespace embul_thiyal
{
    partial class frm_item
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_unitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_itemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editItem = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.cmb_category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_unitPrice);
            this.groupBox1.Controls.Add(this.txt_itemName);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 482);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details";
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.Transparent;
            this.cmb_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_category.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_category.ItemHeight = 30;
            this.cmb_category.Items.AddRange(new object[] {
            "Rice And Curry",
            "Fried Rice",
            "Chopsy Rice",
            "Devilled",
            "Kottu",
            "Noodles",
            "Shorteats",
            "Fried",
            "Juice",
            "Soups",
            "Stew",
            "Roast",
            "Bites"});
            this.cmb_category.Location = new System.Drawing.Point(155, 198);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(326, 36);
            this.cmb_category.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unit price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rs.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item name";
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_unitPrice.DefaultText = "";
            this.txt_unitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_unitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_unitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_unitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_unitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_unitPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_unitPrice.Location = new System.Drawing.Point(228, 263);
            this.txt_unitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.PasswordChar = '\0';
            this.txt_unitPrice.PlaceholderText = "";
            this.txt_unitPrice.SelectedText = "";
            this.txt_unitPrice.Size = new System.Drawing.Size(253, 36);
            this.txt_unitPrice.TabIndex = 1;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemName.DefaultText = "";
            this.txt_itemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_itemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_itemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemName.Location = new System.Drawing.Point(155, 144);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.PlaceholderText = "";
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.Size = new System.Drawing.Size(326, 35);
            this.txt_itemName.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(182, 355);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 45);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_editItem
            // 
            this.btn_editItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editItem.ForeColor = System.Drawing.Color.White;
            this.btn_editItem.Location = new System.Drawing.Point(12, 9);
            this.btn_editItem.Name = "btn_editItem";
            this.btn_editItem.Size = new System.Drawing.Size(174, 78);
            this.btn_editItem.TabIndex = 8;
            this.btn_editItem.Text = "Edit item";
            this.btn_editItem.Click += new System.EventHandler(this.btn_editItem_Click);
            // 
            // dgv_item
            // 
            this.dgv_item.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(614, 204);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.RowHeadersWidth = 51;
            this.dgv_item.RowTemplate.Height = 24;
            this.dgv_item.Size = new System.Drawing.Size(602, 482);
            this.dgv_item.TabIndex = 9;
            // 
            // frm_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.btn_editItem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_itemName;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_unitPrice;
        private Guna.UI2.WinForms.Guna2Button btn_editItem;
        private System.Windows.Forms.DataGridView dgv_item;
    }
}