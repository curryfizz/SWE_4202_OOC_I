using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace lab_final
{
    public partial class Form1 : Form
    {
        List<Students> students = new List<Students>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool f = false;
            using( var reader = new StreamReader(@"student.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Students s = new Students();
                    s.Id = values[0];
                    s.Name = values[1];
                    
                    s.Attendance_out_Of_30 = Convert.ToInt32((string)values[2]);
                    s.Quiz_one_out_Of_30 = Convert.ToInt32((string)values[3]);
                    s.Quiz_two_out_Of_30 = Convert.ToInt32((string)values[4]);
                    s.Quiz_three_out_Of_30 = Convert.ToInt32((string)values[5]);
                    s.Quiz_four_out_Of_30 = Convert.ToInt32((string)values[6]);
                    s.Mid_out_of_75 = Convert.ToInt32((string)values[7]);
                    s.Final_out_of_75 = Convert.ToInt32((string)values[8]);
                    s.Viva_out_of_30 = Convert.ToInt32((string)values[9]);
                    Static_methods.get_percentage(s);
                    Static_methods.get_grade(s);
                    students.Add(s);
                    
                }
            }

            for(int i = 0; i< students.Count; i++)
            {

                student_table.Rows.Add(students[i].Id, students[i].Name, $"{Convert.ToDecimal(string.Format("{0:F2}", students[i].Percent))}%", students[i].Grade);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            var STUDENT =  from student in students
                          where id_search_text_box.Text == student.Id
                          select student;

            foreach(var a in STUDENT)
            {
                attndn_txtbx.Text = $"{a.Attendance_out_Of_30}";
                q1_txtbx.Text = $"{a.Quiz_one_out_Of_30}";
                q2_txtbx.Text = $"{a.Quiz_two_out_Of_30}";
                q3_txtbx.Text = $"{a.Quiz_three_out_Of_30}";
                q4_txtbx.Text = $"{a.Quiz_four_out_Of_30}";
                q_total.Text = $"{Static_methods.get_quiz_total(a)}";
                mid_txtbx.Text = $"{a.Mid_out_of_75}";
                final_txtbx.Text = $"{a.Final_out_of_75}";
                viva_txtbx.Text = $"{a.Viva_out_of_30}";
                total_txtbx.Text = $"{Static_methods.get_total_marks(a)}";
                percent_txtbx.Text = $"{Convert.ToDecimal(string.Format("{0:F2}", a.Percent))}%";
                grade_txtbx.Text = $"{a.Grade}";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
