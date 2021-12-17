namespace pharmacy_managementsystem
{
    partial class Pharmacy_management_system
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
            this.sell_drg_cmb_bx = new System.Windows.Forms.ComboBox();
            this.ordr_rtl_prc_cmb_bx = new System.Windows.Forms.TextBox();
            this.ordr_cst_prce_txt_bx = new System.Windows.Forms.TextBox();
            this.ordr_qty_txt_bx = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.ord_rdrug_name_cmb_bx = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.add_or_update_drug_infobtn = new System.Windows.Forms.Button();
            this.sell_drug_per_unit_prc_txt_bx = new System.Windows.Forms.TextBox();
            this.sell_drug_invntry_txt_bx = new System.Windows.Forms.TextBox();
            this.sell_drug_bill_txt_bx = new System.Windows.Forms.TextBox();
            this.sell_drug_qty_text_bx = new System.Windows.Forms.TextBox();
            this.sell_drug_btn = new System.Windows.Forms.Button();
            this.curr_balance_txt_bx = new System.Windows.Forms.TextBox();
            this.view_blnce_txt_bx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sell_drg_cmb_bx
            // 
            this.sell_drg_cmb_bx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sell_drg_cmb_bx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sell_drg_cmb_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sell_drg_cmb_bx.FormattingEnabled = true;
            this.sell_drg_cmb_bx.Location = new System.Drawing.Point(214, 264);
            this.sell_drg_cmb_bx.Name = "sell_drg_cmb_bx";
            this.sell_drg_cmb_bx.Size = new System.Drawing.Size(237, 24);
            this.sell_drg_cmb_bx.TabIndex = 37;
            this.sell_drg_cmb_bx.SelectedIndexChanged += new System.EventHandler(this.sell_drg_cmb_bx_SelectedIndexChanged);
            // 
            // ordr_rtl_prc_cmb_bx
            // 
            this.ordr_rtl_prc_cmb_bx.Location = new System.Drawing.Point(214, 169);
            this.ordr_rtl_prc_cmb_bx.Name = "ordr_rtl_prc_cmb_bx";
            this.ordr_rtl_prc_cmb_bx.Size = new System.Drawing.Size(237, 22);
            this.ordr_rtl_prc_cmb_bx.TabIndex = 36;
            // 
            // ordr_cst_prce_txt_bx
            // 
            this.ordr_cst_prce_txt_bx.Location = new System.Drawing.Point(214, 133);
            this.ordr_cst_prce_txt_bx.Name = "ordr_cst_prce_txt_bx";
            this.ordr_cst_prce_txt_bx.Size = new System.Drawing.Size(237, 22);
            this.ordr_cst_prce_txt_bx.TabIndex = 35;
            // 
            // ordr_qty_txt_bx
            // 
            this.ordr_qty_txt_bx.Location = new System.Drawing.Point(214, 105);
            this.ordr_qty_txt_bx.Name = "ordr_qty_txt_bx";
            this.ordr_qty_txt_bx.Size = new System.Drawing.Size(237, 22);
            this.ordr_qty_txt_bx.TabIndex = 34;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label14.Location = new System.Drawing.Point(188, 86);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(288, 17);
            this.Label14.TabIndex = 33;
            this.Label14.Text = "If Item is not in List, enter the name manually";
            // 
            // ord_rdrug_name_cmb_bx
            // 
            this.ord_rdrug_name_cmb_bx.FormattingEnabled = true;
            this.ord_rdrug_name_cmb_bx.Location = new System.Drawing.Point(214, 59);
            this.ord_rdrug_name_cmb_bx.Name = "ord_rdrug_name_cmb_bx";
            this.ord_rdrug_name_cmb_bx.Size = new System.Drawing.Size(237, 24);
            this.ord_rdrug_name_cmb_bx.TabIndex = 32;
            this.ord_rdrug_name_cmb_bx.SelectedIndexChanged += new System.EventHandler(this.ord_rdrug_name_cmb_bx_SelectedIndexChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label13.Location = new System.Drawing.Point(144, 235);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(119, 26);
            this.Label13.TabIndex = 31;
            this.Label13.Text = "Sell Drugs:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label12.Location = new System.Drawing.Point(562, 54);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(192, 26);
            this.Label12.TabIndex = 30;
            this.Label12.Text = "Available Balance:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label11.Location = new System.Drawing.Point(131, 26);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(218, 26);
            this.Label11.TabIndex = 29;
            this.Label11.Text = "Place Order for Drug:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(33, 169);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(175, 22);
            this.Label10.TabIndex = 28;
            this.Label10.Text = "Retail price Per Unit:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(86, 136);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(122, 22);
            this.Label9.TabIndex = 27;
            this.Label9.Text = "Cost Per Unit:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(79, 103);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(129, 22);
            this.Label8.TabIndex = 26;
            this.Label8.Text = "Order quantity:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(102, 61);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(106, 22);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "Drug Name:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(514, 95);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(145, 22);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Current Balance:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(106, 403);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(78, 22);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Bill total:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(320, 343);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 22);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Inventory:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(102, 343);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 22);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Quantity:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(58, 304);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(126, 22);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Per Unit Price:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(78, 261);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(106, 22);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Drug Name:";
            // 
            // add_or_update_drug_infobtn
            // 
            this.add_or_update_drug_infobtn.Location = new System.Drawing.Point(191, 197);
            this.add_or_update_drug_infobtn.Name = "add_or_update_drug_infobtn";
            this.add_or_update_drug_infobtn.Size = new System.Drawing.Size(165, 25);
            this.add_or_update_drug_infobtn.TabIndex = 38;
            this.add_or_update_drug_infobtn.Text = "Add/Update drug Info";
            this.add_or_update_drug_infobtn.UseVisualStyleBackColor = true;
            this.add_or_update_drug_infobtn.Click += new System.EventHandler(this.add_or_update_drug_infobtn_Click);
            // 
            // sell_drug_per_unit_prc_txt_bx
            // 
            this.sell_drug_per_unit_prc_txt_bx.Enabled = false;
            this.sell_drug_per_unit_prc_txt_bx.Location = new System.Drawing.Point(214, 304);
            this.sell_drug_per_unit_prc_txt_bx.Name = "sell_drug_per_unit_prc_txt_bx";
            this.sell_drug_per_unit_prc_txt_bx.Size = new System.Drawing.Size(100, 22);
            this.sell_drug_per_unit_prc_txt_bx.TabIndex = 39;
            // 
            // sell_drug_invntry_txt_bx
            // 
            this.sell_drug_invntry_txt_bx.Enabled = false;
            this.sell_drug_invntry_txt_bx.Location = new System.Drawing.Point(414, 343);
            this.sell_drug_invntry_txt_bx.Name = "sell_drug_invntry_txt_bx";
            this.sell_drug_invntry_txt_bx.Size = new System.Drawing.Size(100, 22);
            this.sell_drug_invntry_txt_bx.TabIndex = 40;
            // 
            // sell_drug_bill_txt_bx
            // 
            this.sell_drug_bill_txt_bx.Enabled = false;
            this.sell_drug_bill_txt_bx.Location = new System.Drawing.Point(214, 403);
            this.sell_drug_bill_txt_bx.Name = "sell_drug_bill_txt_bx";
            this.sell_drug_bill_txt_bx.Size = new System.Drawing.Size(100, 22);
            this.sell_drug_bill_txt_bx.TabIndex = 41;
            // 
            // sell_drug_qty_text_bx
            // 
            this.sell_drug_qty_text_bx.Location = new System.Drawing.Point(214, 343);
            this.sell_drug_qty_text_bx.Name = "sell_drug_qty_text_bx";
            this.sell_drug_qty_text_bx.Size = new System.Drawing.Size(100, 22);
            this.sell_drug_qty_text_bx.TabIndex = 42;
            // 
            // sell_drug_btn
            // 
            this.sell_drug_btn.Location = new System.Drawing.Point(349, 402);
            this.sell_drug_btn.Name = "sell_drug_btn";
            this.sell_drug_btn.Size = new System.Drawing.Size(165, 25);
            this.sell_drug_btn.TabIndex = 43;
            this.sell_drug_btn.Text = "Sell Drug";
            this.sell_drug_btn.UseVisualStyleBackColor = true;
            this.sell_drug_btn.Click += new System.EventHandler(this.sell_drug_btn_Click);
            // 
            // curr_balance_txt_bx
            // 
            this.curr_balance_txt_bx.Enabled = false;
            this.curr_balance_txt_bx.Location = new System.Drawing.Point(665, 95);
            this.curr_balance_txt_bx.Name = "curr_balance_txt_bx";
            this.curr_balance_txt_bx.Size = new System.Drawing.Size(100, 22);
            this.curr_balance_txt_bx.TabIndex = 44;
            // 
            // view_blnce_txt_bx
            // 
            this.view_blnce_txt_bx.Location = new System.Drawing.Point(589, 137);
            this.view_blnce_txt_bx.Name = "view_blnce_txt_bx";
            this.view_blnce_txt_bx.Size = new System.Drawing.Size(165, 25);
            this.view_blnce_txt_bx.TabIndex = 45;
            this.view_blnce_txt_bx.Text = "Show Balance";
            this.view_blnce_txt_bx.UseVisualStyleBackColor = true;
            this.view_blnce_txt_bx.Click += new System.EventHandler(this.view_blnce_txt_bx_Click);
            // 
            // Pharmacy_management_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_blnce_txt_bx);
            this.Controls.Add(this.curr_balance_txt_bx);
            this.Controls.Add(this.sell_drug_btn);
            this.Controls.Add(this.sell_drug_qty_text_bx);
            this.Controls.Add(this.sell_drug_bill_txt_bx);
            this.Controls.Add(this.sell_drug_invntry_txt_bx);
            this.Controls.Add(this.sell_drug_per_unit_prc_txt_bx);
            this.Controls.Add(this.add_or_update_drug_infobtn);
            this.Controls.Add(this.sell_drg_cmb_bx);
            this.Controls.Add(this.ordr_rtl_prc_cmb_bx);
            this.Controls.Add(this.ordr_cst_prce_txt_bx);
            this.Controls.Add(this.ordr_qty_txt_bx);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.ord_rdrug_name_cmb_bx);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Pharmacy_management_system";
            this.Text = "Pharmacy Management System";
            this.Load += new System.EventHandler(this.Pharmacy_management_system_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox sell_drg_cmb_bx;
        internal System.Windows.Forms.TextBox ordr_rtl_prc_cmb_bx;
        internal System.Windows.Forms.TextBox ordr_cst_prce_txt_bx;
        internal System.Windows.Forms.TextBox ordr_qty_txt_bx;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox ord_rdrug_name_cmb_bx;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button add_or_update_drug_infobtn;
        private System.Windows.Forms.TextBox sell_drug_per_unit_prc_txt_bx;
        private System.Windows.Forms.TextBox sell_drug_invntry_txt_bx;
        private System.Windows.Forms.TextBox sell_drug_bill_txt_bx;
        private System.Windows.Forms.TextBox sell_drug_qty_text_bx;
        private System.Windows.Forms.Button sell_drug_btn;
        private System.Windows.Forms.TextBox curr_balance_txt_bx;
        private System.Windows.Forms.Button view_blnce_txt_bx;
    }
}

