namespace class_task_1_200042134
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
            this.employeeidlabel = new System.Windows.Forms.Label();
            this.studentidtextbox = new System.Windows.Forms.TextBox();
            this.studentnametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentdeptextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studsavebutton = new System.Windows.Forms.Button();
            this.studclearbutton = new System.Windows.Forms.Button();
            this.teacherdeptextbox = new System.Windows.Forms.TextBox();
            this.teacherdeplabel = new System.Windows.Forms.Label();
            this.teachernametextbox = new System.Windows.Forms.TextBox();
            this.teachernamelabel = new System.Windows.Forms.Label();
            this.teacheridtextbox = new System.Windows.Forms.TextBox();
            this.teacheridlabel = new System.Windows.Forms.Label();
            this.designationtextbox = new System.Windows.Forms.TextBox();
            this.designationlabel = new System.Windows.Forms.Label();
            this.studentsemestertextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salarytextbox = new System.Windows.Forms.TextBox();
            this.salarylabel = new System.Windows.Forms.Label();
            this.studentdetailsbox = new System.Windows.Forms.ListBox();
            this.teacherdetailsbox = new System.Windows.Forms.ListBox();
            this.teacherclearbutton = new System.Windows.Forms.Button();
            this.teachersavebutton = new System.Windows.Forms.Button();
            this.studentdetailsviewbutton = new System.Windows.Forms.Button();
            this.teacherdetailsviewbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeidlabel
            // 
            this.employeeidlabel.AutoSize = true;
            this.employeeidlabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeidlabel.Location = new System.Drawing.Point(31, 63);
            this.employeeidlabel.Name = "employeeidlabel";
            this.employeeidlabel.Size = new System.Drawing.Size(104, 24);
            this.employeeidlabel.TabIndex = 0;
            this.employeeidlabel.Text = "Student ID";
            // 
            // studentidtextbox
            // 
            this.studentidtextbox.Location = new System.Drawing.Point(157, 67);
            this.studentidtextbox.Name = "studentidtextbox";
            this.studentidtextbox.Size = new System.Drawing.Size(249, 22);
            this.studentidtextbox.TabIndex = 1;
            this.studentidtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // studentnametextbox
            // 
            this.studentnametextbox.Location = new System.Drawing.Point(157, 120);
            this.studentnametextbox.Name = "studentnametextbox";
            this.studentnametextbox.Size = new System.Drawing.Size(249, 22);
            this.studentnametextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // studentdeptextbox
            // 
            this.studentdeptextbox.Location = new System.Drawing.Point(157, 175);
            this.studentdeptextbox.Name = "studentdeptextbox";
            this.studentdeptextbox.Size = new System.Drawing.Size(249, 22);
            this.studentdeptextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department";
            // 
            // studsavebutton
            // 
            this.studsavebutton.Location = new System.Drawing.Point(76, 278);
            this.studsavebutton.Name = "studsavebutton";
            this.studsavebutton.Size = new System.Drawing.Size(118, 36);
            this.studsavebutton.TabIndex = 6;
            this.studsavebutton.Text = "Save";
            this.studsavebutton.UseVisualStyleBackColor = true;
            this.studsavebutton.Click += new System.EventHandler(this.studentsavebutton_onclick);
            // 
            // studclearbutton
            // 
            this.studclearbutton.Location = new System.Drawing.Point(280, 278);
            this.studclearbutton.Name = "studclearbutton";
            this.studclearbutton.Size = new System.Drawing.Size(118, 36);
            this.studclearbutton.TabIndex = 7;
            this.studclearbutton.Text = "Clear";
            this.studclearbutton.UseVisualStyleBackColor = true;
            this.studclearbutton.Click += new System.EventHandler(this.studentclearbutton_onclick);
            // 
            // teacherdeptextbox
            // 
            this.teacherdeptextbox.Location = new System.Drawing.Point(664, 149);
            this.teacherdeptextbox.Name = "teacherdeptextbox";
            this.teacherdeptextbox.Size = new System.Drawing.Size(249, 22);
            this.teacherdeptextbox.TabIndex = 16;
            // 
            // teacherdeplabel
            // 
            this.teacherdeplabel.AutoSize = true;
            this.teacherdeplabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherdeplabel.Location = new System.Drawing.Point(510, 145);
            this.teacherdeplabel.Name = "teacherdeplabel";
            this.teacherdeplabel.Size = new System.Drawing.Size(118, 24);
            this.teacherdeplabel.TabIndex = 15;
            this.teacherdeplabel.Text = "Department";
            // 
            // teachernametextbox
            // 
            this.teachernametextbox.Location = new System.Drawing.Point(664, 94);
            this.teachernametextbox.Name = "teachernametextbox";
            this.teachernametextbox.Size = new System.Drawing.Size(249, 22);
            this.teachernametextbox.TabIndex = 14;
            // 
            // teachernamelabel
            // 
            this.teachernamelabel.AutoSize = true;
            this.teachernamelabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachernamelabel.Location = new System.Drawing.Point(565, 90);
            this.teachernamelabel.Name = "teachernamelabel";
            this.teachernamelabel.Size = new System.Drawing.Size(63, 24);
            this.teachernamelabel.TabIndex = 13;
            this.teachernamelabel.Text = "Name";
            // 
            // teacheridtextbox
            // 
            this.teacheridtextbox.Location = new System.Drawing.Point(664, 41);
            this.teacheridtextbox.Name = "teacheridtextbox";
            this.teacheridtextbox.Size = new System.Drawing.Size(249, 22);
            this.teacheridtextbox.TabIndex = 12;
            // 
            // teacheridlabel
            // 
            this.teacheridlabel.AutoSize = true;
            this.teacheridlabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacheridlabel.Location = new System.Drawing.Point(522, 37);
            this.teacheridlabel.Name = "teacheridlabel";
            this.teacheridlabel.Size = new System.Drawing.Size(106, 24);
            this.teacheridlabel.TabIndex = 11;
            this.teacheridlabel.Text = "Teacher ID";
            // 
            // designationtextbox
            // 
            this.designationtextbox.Location = new System.Drawing.Point(664, 203);
            this.designationtextbox.Name = "designationtextbox";
            this.designationtextbox.Size = new System.Drawing.Size(249, 22);
            this.designationtextbox.TabIndex = 18;
            // 
            // designationlabel
            // 
            this.designationlabel.AutoSize = true;
            this.designationlabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationlabel.Location = new System.Drawing.Point(510, 199);
            this.designationlabel.Name = "designationlabel";
            this.designationlabel.Size = new System.Drawing.Size(116, 24);
            this.designationlabel.TabIndex = 17;
            this.designationlabel.Text = "Designation";
            // 
            // studentsemestertextbox
            // 
            this.studentsemestertextbox.Location = new System.Drawing.Point(157, 225);
            this.studentsemestertextbox.Name = "studentsemestertextbox";
            this.studentsemestertextbox.Size = new System.Drawing.Size(249, 22);
            this.studentsemestertextbox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Semester";
            // 
            // salarytextbox
            // 
            this.salarytextbox.Location = new System.Drawing.Point(664, 256);
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(249, 22);
            this.salarytextbox.TabIndex = 22;
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarylabel.Location = new System.Drawing.Point(557, 252);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(69, 24);
            this.salarylabel.TabIndex = 21;
            this.salarylabel.Text = "Salary";
            // 
            // studentdetailsbox
            // 
            this.studentdetailsbox.FormattingEnabled = true;
            this.studentdetailsbox.ItemHeight = 16;
            this.studentdetailsbox.Location = new System.Drawing.Point(49, 320);
            this.studentdetailsbox.Name = "studentdetailsbox";
            this.studentdetailsbox.Size = new System.Drawing.Size(402, 180);
            this.studentdetailsbox.TabIndex = 23;
            // 
            // teacherdetailsbox
            // 
            this.teacherdetailsbox.FormattingEnabled = true;
            this.teacherdetailsbox.ItemHeight = 16;
            this.teacherdetailsbox.Location = new System.Drawing.Point(499, 339);
            this.teacherdetailsbox.Name = "teacherdetailsbox";
            this.teacherdetailsbox.Size = new System.Drawing.Size(432, 164);
            this.teacherdetailsbox.TabIndex = 26;
            // 
            // teacherclearbutton
            // 
            this.teacherclearbutton.Location = new System.Drawing.Point(765, 297);
            this.teacherclearbutton.Name = "teacherclearbutton";
            this.teacherclearbutton.Size = new System.Drawing.Size(118, 36);
            this.teacherclearbutton.TabIndex = 25;
            this.teacherclearbutton.Text = "Clear";
            this.teacherclearbutton.UseVisualStyleBackColor = true;
            this.teacherclearbutton.Click += new System.EventHandler(this.teacherclear_onclick);
            // 
            // teachersavebutton
            // 
            this.teachersavebutton.Location = new System.Drawing.Point(561, 297);
            this.teachersavebutton.Name = "teachersavebutton";
            this.teachersavebutton.Size = new System.Drawing.Size(118, 36);
            this.teachersavebutton.TabIndex = 24;
            this.teachersavebutton.Text = "Save";
            this.teachersavebutton.UseVisualStyleBackColor = true;
            this.teachersavebutton.Click += new System.EventHandler(this.teachersavebutton_onclick);
            // 
            // studentdetailsviewbutton
            // 
            this.studentdetailsviewbutton.Location = new System.Drawing.Point(166, 513);
            this.studentdetailsviewbutton.Name = "studentdetailsviewbutton";
            this.studentdetailsviewbutton.Size = new System.Drawing.Size(138, 36);
            this.studentdetailsviewbutton.TabIndex = 27;
            this.studentdetailsviewbutton.Text = "Show student details";
            this.studentdetailsviewbutton.UseVisualStyleBackColor = true;
            this.studentdetailsviewbutton.Click += new System.EventHandler(this.showstudentdetails_onclick);
            // 
            // teacherdetailsviewbutton
            // 
            this.teacherdetailsviewbutton.Location = new System.Drawing.Point(664, 509);
            this.teacherdetailsviewbutton.Name = "teacherdetailsviewbutton";
            this.teacherdetailsviewbutton.Size = new System.Drawing.Size(155, 36);
            this.teacherdetailsviewbutton.TabIndex = 28;
            this.teacherdetailsviewbutton.Text = "Show teacher details";
            this.teacherdetailsviewbutton.UseVisualStyleBackColor = true;
            this.teacherdetailsviewbutton.Click += new System.EventHandler(this.showteachdetails_onclick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(943, 561);
            this.Controls.Add(this.teacherdetailsviewbutton);
            this.Controls.Add(this.studentdetailsviewbutton);
            this.Controls.Add(this.teacherdetailsbox);
            this.Controls.Add(this.teacherclearbutton);
            this.Controls.Add(this.teachersavebutton);
            this.Controls.Add(this.studentdetailsbox);
            this.Controls.Add(this.salarytextbox);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.studentsemestertextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.designationtextbox);
            this.Controls.Add(this.designationlabel);
            this.Controls.Add(this.teacherdeptextbox);
            this.Controls.Add(this.teacherdeplabel);
            this.Controls.Add(this.teachernametextbox);
            this.Controls.Add(this.teachernamelabel);
            this.Controls.Add(this.teacheridtextbox);
            this.Controls.Add(this.teacheridlabel);
            this.Controls.Add(this.studclearbutton);
            this.Controls.Add(this.studsavebutton);
            this.Controls.Add(this.studentdeptextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentnametextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentidtextbox);
            this.Controls.Add(this.employeeidlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeidlabel;
        private System.Windows.Forms.TextBox studentidtextbox;
        private System.Windows.Forms.TextBox studentnametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentdeptextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button studsavebutton;
        private System.Windows.Forms.Button studclearbutton;
        private System.Windows.Forms.TextBox teacherdeptextbox;
        private System.Windows.Forms.Label teacherdeplabel;
        private System.Windows.Forms.TextBox teachernametextbox;
        private System.Windows.Forms.Label teachernamelabel;
        private System.Windows.Forms.TextBox teacheridtextbox;
        private System.Windows.Forms.Label teacheridlabel;
        private System.Windows.Forms.TextBox designationtextbox;
        private System.Windows.Forms.Label designationlabel;
        private System.Windows.Forms.TextBox studentsemestertextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salarytextbox;
        private System.Windows.Forms.Label salarylabel;
        private System.Windows.Forms.ListBox studentdetailsbox;
        private System.Windows.Forms.ListBox teacherdetailsbox;
        private System.Windows.Forms.Button teacherclearbutton;
        private System.Windows.Forms.Button teachersavebutton;
        private System.Windows.Forms.Button studentdetailsviewbutton;
        private System.Windows.Forms.Button teacherdetailsviewbutton;
    }
}

