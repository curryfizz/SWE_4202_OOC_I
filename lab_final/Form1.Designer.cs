namespace lab_final
{
    partial class Form1
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
            this.student_table = new System.Windows.Forms.DataGridView();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.id_search_text_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.attndn_txtbx = new System.Windows.Forms.TextBox();
            this.q1_txtbx = new System.Windows.Forms.TextBox();
            this.q2_txtbx = new System.Windows.Forms.TextBox();
            this.q3_txtbx = new System.Windows.Forms.TextBox();
            this.q4_txtbx = new System.Windows.Forms.TextBox();
            this.q_total = new System.Windows.Forms.TextBox();
            this.mid_txtbx = new System.Windows.Forms.TextBox();
            this.final_txtbx = new System.Windows.Forms.TextBox();
            this.viva_txtbx = new System.Windows.Forms.TextBox();
            this.total_txtbx = new System.Windows.Forms.TextBox();
            this.percent_txtbx = new System.Windows.Forms.TextBox();
            this.grade_txtbx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_table)).BeginInit();
            this.SuspendLayout();
            // 
            // student_table
            // 
            this.student_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.name_col,
            this.percent_col,
            this.grade_col});
            this.student_table.Location = new System.Drawing.Point(12, 116);
            this.student_table.Name = "student_table";
            this.student_table.RowHeadersWidth = 51;
            this.student_table.RowTemplate.Height = 24;
            this.student_table.Size = new System.Drawing.Size(741, 454);
            this.student_table.TabIndex = 0;
            this.student_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_col
            // 
            this.id_col.HeaderText = "ID";
            this.id_col.MinimumWidth = 6;
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            this.id_col.Width = 125;
            // 
            // name_col
            // 
            this.name_col.HeaderText = "Name";
            this.name_col.MinimumWidth = 6;
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            this.name_col.Width = 125;
            // 
            // percent_col
            // 
            this.percent_col.HeaderText = "Percentage";
            this.percent_col.MinimumWidth = 6;
            this.percent_col.Name = "percent_col";
            this.percent_col.ReadOnly = true;
            this.percent_col.Width = 125;
            // 
            // grade_col
            // 
            this.grade_col.HeaderText = "Grade";
            this.grade_col.MinimumWidth = 6;
            this.grade_col.Name = "grade_col";
            this.grade_col.ReadOnly = true;
            this.grade_col.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "IUT Result Processing System";
            // 
            // id_search_text_box
            // 
            this.id_search_text_box.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_search_text_box.Location = new System.Drawing.Point(818, 101);
            this.id_search_text_box.Name = "id_search_text_box";
            this.id_search_text_box.Size = new System.Drawing.Size(198, 32);
            this.id_search_text_box.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(828, 139);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(160, 37);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search By ID";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Course Name: Object Oriented Concepts I";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(773, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attendance:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quiz 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(773, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quiz 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(773, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quiz 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(773, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quiz 4:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(773, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quiz Total (Best 3):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(777, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Percentage:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(777, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total (Out of 300):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(777, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Viva:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(777, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = "Final:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(777, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Mid:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(777, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Grade:";
            // 
            // attndn_txtbx
            // 
            this.attndn_txtbx.Enabled = false;
            this.attndn_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attndn_txtbx.Location = new System.Drawing.Point(884, 206);
            this.attndn_txtbx.Name = "attndn_txtbx";
            this.attndn_txtbx.Size = new System.Drawing.Size(102, 26);
            this.attndn_txtbx.TabIndex = 17;
            // 
            // q1_txtbx
            // 
            this.q1_txtbx.Enabled = false;
            this.q1_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_txtbx.Location = new System.Drawing.Point(839, 233);
            this.q1_txtbx.Name = "q1_txtbx";
            this.q1_txtbx.Size = new System.Drawing.Size(102, 26);
            this.q1_txtbx.TabIndex = 18;
            // 
            // q2_txtbx
            // 
            this.q2_txtbx.Enabled = false;
            this.q2_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_txtbx.Location = new System.Drawing.Point(839, 253);
            this.q2_txtbx.Name = "q2_txtbx";
            this.q2_txtbx.Size = new System.Drawing.Size(102, 26);
            this.q2_txtbx.TabIndex = 19;
            // 
            // q3_txtbx
            // 
            this.q3_txtbx.Enabled = false;
            this.q3_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3_txtbx.Location = new System.Drawing.Point(839, 275);
            this.q3_txtbx.Name = "q3_txtbx";
            this.q3_txtbx.Size = new System.Drawing.Size(102, 26);
            this.q3_txtbx.TabIndex = 20;
            // 
            // q4_txtbx
            // 
            this.q4_txtbx.Enabled = false;
            this.q4_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4_txtbx.Location = new System.Drawing.Point(839, 298);
            this.q4_txtbx.Name = "q4_txtbx";
            this.q4_txtbx.Size = new System.Drawing.Size(102, 26);
            this.q4_txtbx.TabIndex = 21;
            // 
            // q_total
            // 
            this.q_total.Enabled = false;
            this.q_total.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_total.Location = new System.Drawing.Point(935, 324);
            this.q_total.Name = "q_total";
            this.q_total.Size = new System.Drawing.Size(102, 26);
            this.q_total.TabIndex = 22;
            // 
            // mid_txtbx
            // 
            this.mid_txtbx.Enabled = false;
            this.mid_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid_txtbx.Location = new System.Drawing.Point(827, 346);
            this.mid_txtbx.Name = "mid_txtbx";
            this.mid_txtbx.Size = new System.Drawing.Size(102, 26);
            this.mid_txtbx.TabIndex = 23;
            // 
            // final_txtbx
            // 
            this.final_txtbx.Enabled = false;
            this.final_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_txtbx.Location = new System.Drawing.Point(828, 369);
            this.final_txtbx.Name = "final_txtbx";
            this.final_txtbx.Size = new System.Drawing.Size(102, 26);
            this.final_txtbx.TabIndex = 24;
            // 
            // viva_txtbx
            // 
            this.viva_txtbx.Enabled = false;
            this.viva_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viva_txtbx.Location = new System.Drawing.Point(827, 392);
            this.viva_txtbx.Name = "viva_txtbx";
            this.viva_txtbx.Size = new System.Drawing.Size(102, 26);
            this.viva_txtbx.TabIndex = 25;
            // 
            // total_txtbx
            // 
            this.total_txtbx.Enabled = false;
            this.total_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txtbx.Location = new System.Drawing.Point(935, 413);
            this.total_txtbx.Name = "total_txtbx";
            this.total_txtbx.Size = new System.Drawing.Size(102, 26);
            this.total_txtbx.TabIndex = 26;
            // 
            // percent_txtbx
            // 
            this.percent_txtbx.Enabled = false;
            this.percent_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent_txtbx.Location = new System.Drawing.Point(886, 438);
            this.percent_txtbx.Name = "percent_txtbx";
            this.percent_txtbx.Size = new System.Drawing.Size(102, 26);
            this.percent_txtbx.TabIndex = 27;
            // 
            // grade_txtbx
            // 
            this.grade_txtbx.Enabled = false;
            this.grade_txtbx.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_txtbx.ForeColor = System.Drawing.Color.Red;
            this.grade_txtbx.Location = new System.Drawing.Point(844, 461);
            this.grade_txtbx.Name = "grade_txtbx";
            this.grade_txtbx.Size = new System.Drawing.Size(102, 26);
            this.grade_txtbx.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(841, 532);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 24);
            this.label14.TabIndex = 29;
            this.label14.Text = "Developed by: ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(968, 532);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 24);
            this.label15.TabIndex = 30;
            this.label15.Text = "200042134";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 582);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grade_txtbx);
            this.Controls.Add(this.percent_txtbx);
            this.Controls.Add(this.total_txtbx);
            this.Controls.Add(this.viva_txtbx);
            this.Controls.Add(this.final_txtbx);
            this.Controls.Add(this.mid_txtbx);
            this.Controls.Add(this.q_total);
            this.Controls.Add(this.q4_txtbx);
            this.Controls.Add(this.q3_txtbx);
            this.Controls.Add(this.q2_txtbx);
            this.Controls.Add(this.q1_txtbx);
            this.Controls.Add(this.attndn_txtbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.id_search_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student_table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView student_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade_col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_search_text_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox attndn_txtbx;
        private System.Windows.Forms.TextBox q1_txtbx;
        private System.Windows.Forms.TextBox q2_txtbx;
        private System.Windows.Forms.TextBox q3_txtbx;
        private System.Windows.Forms.TextBox q4_txtbx;
        private System.Windows.Forms.TextBox q_total;
        private System.Windows.Forms.TextBox mid_txtbx;
        private System.Windows.Forms.TextBox final_txtbx;
        private System.Windows.Forms.TextBox viva_txtbx;
        private System.Windows.Forms.TextBox total_txtbx;
        private System.Windows.Forms.TextBox percent_txtbx;
        private System.Windows.Forms.TextBox grade_txtbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

