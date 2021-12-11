namespace room_rental
{
    partial class room_rentals_frm
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
            this.room_quantity_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_single_room_btn = new System.Windows.Forms.Button();
            this.rent_room_btn = new System.Windows.Forms.Button();
            this.view_rooms_listbox = new System.Windows.Forms.ListBox();
            this.add_dbl_room_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.num_single_rooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qty_dbl_rooms_txtbox = new System.Windows.Forms.TextBox();
            this.sing_room_type_choice = new System.Windows.Forms.ComboBox();
            this.sing_has_AC_bool = new System.Windows.Forms.CheckBox();
            this.dbl_has_ac_bool = new System.Windows.Forms.CheckBox();
            this.sing_has_gmg_bool = new System.Windows.Forms.CheckBox();
            this.dbl_room_type_choice = new System.Windows.Forms.ComboBox();
            this.combined_room_list = new System.Windows.Forms.ComboBox();
            this.c_break_bool = new System.Windows.Forms.CheckBox();
            this.extra_tv_bool = new System.Windows.Forms.CheckBox();
            this.show_room_btn = new System.Windows.Forms.Button();
            this.all_rooms_choose = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // room_quantity_txtbox
            // 
            this.room_quantity_txtbox.Location = new System.Drawing.Point(945, 105);
            this.room_quantity_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.room_quantity_txtbox.Name = "room_quantity_txtbox";
            this.room_quantity_txtbox.Size = new System.Drawing.Size(146, 30);
            this.room_quantity_txtbox.TabIndex = 11;
            this.room_quantity_txtbox.TextChanged += new System.EventHandler(this.room_quantity_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Has A/C?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Has Gaming Setup?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // add_single_room_btn
            // 
            this.add_single_room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.add_single_room_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.add_single_room_btn.ForeColor = System.Drawing.Color.White;
            this.add_single_room_btn.Location = new System.Drawing.Point(194, 210);
            this.add_single_room_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_single_room_btn.Name = "add_single_room_btn";
            this.add_single_room_btn.Size = new System.Drawing.Size(207, 42);
            this.add_single_room_btn.TabIndex = 4;
            this.add_single_room_btn.Text = "Add Single Room";
            this.add_single_room_btn.UseVisualStyleBackColor = false;
            this.add_single_room_btn.Click += new System.EventHandler(this.add_single_room_btn_Click);
            // 
            // rent_room_btn
            // 
            this.rent_room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.rent_room_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rent_room_btn.ForeColor = System.Drawing.Color.White;
            this.rent_room_btn.Location = new System.Drawing.Point(862, 159);
            this.rent_room_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rent_room_btn.Name = "rent_room_btn";
            this.rent_room_btn.Size = new System.Drawing.Size(207, 42);
            this.rent_room_btn.TabIndex = 12;
            this.rent_room_btn.Text = "Rent";
            this.rent_room_btn.UseVisualStyleBackColor = false;
            this.rent_room_btn.Click += new System.EventHandler(this.rent_room_btn_Click);
            // 
            // view_rooms_listbox
            // 
            this.view_rooms_listbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.view_rooms_listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view_rooms_listbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.view_rooms_listbox.FormattingEnabled = true;
            this.view_rooms_listbox.ItemHeight = 23;
            this.view_rooms_listbox.Location = new System.Drawing.Point(753, 464);
            this.view_rooms_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_rooms_listbox.Name = "view_rooms_listbox";
            this.view_rooms_listbox.Size = new System.Drawing.Size(412, 232);
            this.view_rooms_listbox.TabIndex = 20;
            this.view_rooms_listbox.SelectedIndexChanged += new System.EventHandler(this.view_rooms_listbox_SelectedIndexChanged);
            // 
            // add_dbl_room_btn
            // 
            this.add_dbl_room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.add_dbl_room_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.add_dbl_room_btn.ForeColor = System.Drawing.Color.White;
            this.add_dbl_room_btn.Location = new System.Drawing.Point(194, 567);
            this.add_dbl_room_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_dbl_room_btn.Name = "add_dbl_room_btn";
            this.add_dbl_room_btn.Size = new System.Drawing.Size(207, 42);
            this.add_dbl_room_btn.TabIndex = 21;
            this.add_dbl_room_btn.Text = "Add Double Room";
            this.add_dbl_room_btn.UseVisualStyleBackColor = false;
            this.add_dbl_room_btn.Click += new System.EventHandler(this.add_dbl_room_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Complementary Breakfast?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "Extra TV?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Has A/C?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Room name";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(15, 144);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(115, 18);
            this.Quantity.TabIndex = 39;
            this.Quantity.Text = "No. of Rooms";
            // 
            // num_single_rooms
            // 
            this.num_single_rooms.Location = new System.Drawing.Point(283, 148);
            this.num_single_rooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_single_rooms.Name = "num_single_rooms";
            this.num_single_rooms.Size = new System.Drawing.Size(192, 30);
            this.num_single_rooms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "No. of Rooms";
            // 
            // qty_dbl_rooms_txtbox
            // 
            this.qty_dbl_rooms_txtbox.Location = new System.Drawing.Point(312, 510);
            this.qty_dbl_rooms_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qty_dbl_rooms_txtbox.Name = "qty_dbl_rooms_txtbox";
            this.qty_dbl_rooms_txtbox.Size = new System.Drawing.Size(192, 30);
            this.qty_dbl_rooms_txtbox.TabIndex = 9;
            // 
            // sing_room_type_choice
            // 
            this.sing_room_type_choice.FormattingEnabled = true;
            this.sing_room_type_choice.Items.AddRange(new object[] {
            "Single Room ",
            "Single Room+A/C",
            "Single Room+A/C+Gaming Setup",
            "Single Room+Gaming Setup"});
            this.sing_room_type_choice.Location = new System.Drawing.Point(283, 26);
            this.sing_room_type_choice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sing_room_type_choice.Name = "sing_room_type_choice";
            this.sing_room_type_choice.Size = new System.Drawing.Size(392, 31);
            this.sing_room_type_choice.TabIndex = 0;
            this.sing_room_type_choice.SelectedIndexChanged += new System.EventHandler(this.sing_room_type_choice_SelectedIndexChanged);
            // 
            // sing_has_AC_bool
            // 
            this.sing_has_AC_bool.AutoSize = true;
            this.sing_has_AC_bool.Location = new System.Drawing.Point(283, 70);
            this.sing_has_AC_bool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sing_has_AC_bool.Name = "sing_has_AC_bool";
            this.sing_has_AC_bool.Size = new System.Drawing.Size(18, 17);
            this.sing_has_AC_bool.TabIndex = 1;
            this.sing_has_AC_bool.UseVisualStyleBackColor = true;
            // 
            // dbl_has_ac_bool
            // 
            this.dbl_has_ac_bool.AutoSize = true;
            this.dbl_has_ac_bool.Location = new System.Drawing.Point(312, 393);
            this.dbl_has_ac_bool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dbl_has_ac_bool.Name = "dbl_has_ac_bool";
            this.dbl_has_ac_bool.Size = new System.Drawing.Size(18, 17);
            this.dbl_has_ac_bool.TabIndex = 6;
            this.dbl_has_ac_bool.UseVisualStyleBackColor = true;
            // 
            // sing_has_gmg_bool
            // 
            this.sing_has_gmg_bool.AutoSize = true;
            this.sing_has_gmg_bool.Location = new System.Drawing.Point(283, 111);
            this.sing_has_gmg_bool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sing_has_gmg_bool.Name = "sing_has_gmg_bool";
            this.sing_has_gmg_bool.Size = new System.Drawing.Size(18, 17);
            this.sing_has_gmg_bool.TabIndex = 2;
            this.sing_has_gmg_bool.UseVisualStyleBackColor = true;
            // 
            // dbl_room_type_choice
            // 
            this.dbl_room_type_choice.FormattingEnabled = true;
            this.dbl_room_type_choice.Items.AddRange(new object[] {
            "Double Room",
            "Double Room+A/C",
            "Double Room+Extra TV",
            "Double Room+C.Breakfast",
            "Double Room+A/C+Extra TV",
            "Double Room+A/C+C.Breakfast",
            "Double Room+A/C+Extra TV+C.Breakfast",
            "Double Room+Extra TV+C.Breakfast"});
            this.dbl_room_type_choice.Location = new System.Drawing.Point(312, 348);
            this.dbl_room_type_choice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dbl_room_type_choice.Name = "dbl_room_type_choice";
            this.dbl_room_type_choice.Size = new System.Drawing.Size(362, 31);
            this.dbl_room_type_choice.TabIndex = 5;
            this.dbl_room_type_choice.SelectedIndexChanged += new System.EventHandler(this.dbl_room_type_choice_SelectedIndexChanged);
            // 
            // combined_room_list
            // 
            this.combined_room_list.FormattingEnabled = true;
            this.combined_room_list.Items.AddRange(new object[] {
            "Single Room ",
            "Single Room+A/C",
            "Single Room+A/C+Gaming Setup",
            "Single Room+Gaming Setup",
            "Double Room ",
            "Double Room+A/C",
            "Double Room+A/C+Extra Bed",
            "Double Room+A/C+C.Break",
            "Double Room+A/C+Extra Bed+C.Break",
            "Double Room+Extra Bed",
            "Double Room+Extra Bed+C.Break"});
            this.combined_room_list.Location = new System.Drawing.Point(753, 347);
            this.combined_room_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combined_room_list.Name = "combined_room_list";
            this.combined_room_list.Size = new System.Drawing.Size(412, 31);
            this.combined_room_list.TabIndex = 13;
            // 
            // c_break_bool
            // 
            this.c_break_bool.AutoSize = true;
            this.c_break_bool.Location = new System.Drawing.Point(312, 466);
            this.c_break_bool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_break_bool.Name = "c_break_bool";
            this.c_break_bool.Size = new System.Drawing.Size(18, 17);
            this.c_break_bool.TabIndex = 8;
            this.c_break_bool.UseVisualStyleBackColor = true;
            // 
            // extra_tv_bool
            // 
            this.extra_tv_bool.AutoSize = true;
            this.extra_tv_bool.Location = new System.Drawing.Point(312, 428);
            this.extra_tv_bool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extra_tv_bool.Name = "extra_tv_bool";
            this.extra_tv_bool.Size = new System.Drawing.Size(18, 17);
            this.extra_tv_bool.TabIndex = 7;
            this.extra_tv_bool.UseVisualStyleBackColor = true;
            // 
            // show_room_btn
            // 
            this.show_room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.show_room_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.show_room_btn.ForeColor = System.Drawing.Color.White;
            this.show_room_btn.Location = new System.Drawing.Point(862, 389);
            this.show_room_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_room_btn.Name = "show_room_btn";
            this.show_room_btn.Size = new System.Drawing.Size(207, 42);
            this.show_room_btn.TabIndex = 14;
            this.show_room_btn.Text = "Show available rooms";
            this.show_room_btn.UseVisualStyleBackColor = false;
            this.show_room_btn.Click += new System.EventHandler(this.show_room_btn_Click);
            // 
            // all_rooms_choose
            // 
            this.all_rooms_choose.FormattingEnabled = true;
            this.all_rooms_choose.Items.AddRange(new object[] {
            "Single Room ",
            "Single Room+A/C",
            "Single Room+A/C+Gaming Setup",
            "Single Room+Gaming Setup",
            "Double Room ",
            "Double Room+A/C",
            "Double Room+A/C+Extra Bed",
            "Double Room+A/C+C.Break",
            "Double Room+A/C+Extra Bed+C.Break",
            "Double Room+Extra Bed",
            "Double Room+Extra Bed+C.Break"});
            this.all_rooms_choose.Location = new System.Drawing.Point(768, 55);
            this.all_rooms_choose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.all_rooms_choose.Name = "all_rooms_choose";
            this.all_rooms_choose.Size = new System.Drawing.Size(412, 31);
            this.all_rooms_choose.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "No. of Rooms";
            // 
            // room_rentals_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1198, 834);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.all_rooms_choose);
            this.Controls.Add(this.show_room_btn);
            this.Controls.Add(this.extra_tv_bool);
            this.Controls.Add(this.c_break_bool);
            this.Controls.Add(this.combined_room_list);
            this.Controls.Add(this.dbl_room_type_choice);
            this.Controls.Add(this.sing_has_gmg_bool);
            this.Controls.Add(this.dbl_has_ac_bool);
            this.Controls.Add(this.sing_has_AC_bool);
            this.Controls.Add(this.sing_room_type_choice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qty_dbl_rooms_txtbox);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.num_single_rooms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.add_dbl_room_btn);
            this.Controls.Add(this.view_rooms_listbox);
            this.Controls.Add(this.rent_room_btn);
            this.Controls.Add(this.add_single_room_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room_quantity_txtbox);
            this.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "room_rentals_frm";
            this.Text = "Room Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox room_quantity_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_single_room_btn;
        private System.Windows.Forms.Button rent_room_btn;
        private System.Windows.Forms.ListBox view_rooms_listbox;
        private System.Windows.Forms.Button add_dbl_room_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox num_single_rooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qty_dbl_rooms_txtbox;
        private System.Windows.Forms.ComboBox sing_room_type_choice;
        private System.Windows.Forms.CheckBox sing_has_AC_bool;
        private System.Windows.Forms.CheckBox dbl_has_ac_bool;
        private System.Windows.Forms.CheckBox sing_has_gmg_bool;
        private System.Windows.Forms.ComboBox dbl_room_type_choice;
        private System.Windows.Forms.ComboBox combined_room_list;
        private System.Windows.Forms.CheckBox c_break_bool;
        private System.Windows.Forms.CheckBox extra_tv_bool;
        private System.Windows.Forms.Button show_room_btn;
        private System.Windows.Forms.ComboBox all_rooms_choose;
        private System.Windows.Forms.Label label3;
    }
}

