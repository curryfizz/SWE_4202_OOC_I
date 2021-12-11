using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_1_200042134
{
    internal class Student
    {
        private string student_id;
        private string student_name;
        private string student_dept;
        private string student_semester;
        public void setstudent_info(string id, string name, string dept, string sem)
        {
            this.student_id = id;
            this.student_name = name;
            this.student_dept = dept;
            this.student_semester = sem;
        }

        public void setstudentid(string id)
        {
            this.student_id = id;
        }

        public void setstudentname(string n)
        {
            this.student_name = n;
        }

        public void setstudentdept(string d)
        {
            this.student_dept = d;
        }

        public void setstudentsem(string s)
        {
            this.student_semester = s;
        }
        public string getstudent_info()
        {
            string student_info = student_id + "\t" + student_name + "\t" + student_dept + "\t" + student_semester;
            return student_info;
        }
    }


}
