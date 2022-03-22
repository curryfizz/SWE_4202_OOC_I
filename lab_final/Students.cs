using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_final
{
    public class Students
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private int attendance_out_of_30;
        public int Attendance_out_Of_30
        {
            get { return attendance_out_of_30;}
            set { attendance_out_of_30 = value; }
        }

        private int quiz_one_out_of_30;
        public int Quiz_one_out_Of_30
        {
            get { return quiz_one_out_of_30; }
            set { quiz_one_out_of_30 = value ; }
        }

        private int quiz_two_out_of_30;
        public int Quiz_two_out_Of_30
        {
            get { return quiz_two_out_of_30; }
            set { quiz_two_out_of_30 = value; }
        }

        private int quiz_three_out_of_30;
        public int Quiz_three_out_Of_30
        {
            get { return quiz_three_out_of_30; }
            set { quiz_three_out_of_30 = value; }
        }
        
        private int quiz_four_out_of_30;
        public int Quiz_four_out_Of_30
        {
            get { return quiz_four_out_of_30; }
            set { quiz_four_out_of_30 = value; }
        }

        private int mid_out_of_75;
        public int Mid_out_of_75
        {
            get { return mid_out_of_75; }
            set { mid_out_of_75 = value; }
        }

        private int final_out_of_75;
        public int Final_out_of_75
        {
            get { return final_out_of_75; }
            set { final_out_of_75 = value; }
        }

        private int viva_out_of_30;
        public int Viva_out_of_30
        {
            get { return viva_out_of_30; }
            set { viva_out_of_30 = value; }
        }

        private double percentage;
        public double Percent
        {
            get { return percentage; }
            set { percentage = value; }
        }

        private string grade;
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}
