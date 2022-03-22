using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_final
{
    public static class Static_methods
    {
        public static double get_quiz_total(Students a)
        {
            double[] marks = { a.Quiz_one_out_Of_30, a.Quiz_two_out_Of_30, a.Quiz_three_out_Of_30, a.Quiz_four_out_Of_30 };
            Array.Sort(marks);
            return marks[1]+marks[2]+marks[3];
        }

        public static double get_total_marks(Students a)
        {
            return a.Attendance_out_Of_30+get_quiz_total(a) +a.Mid_out_of_75 + a.Final_out_of_75 + a.Viva_out_of_30;
        }
        public static void get_percentage(Students a)
        {
            a.Percent =  get_total_marks(a) *100/ 300;

        }

        public static void get_grade(Students a)
        {
            if(a.Percent >= 80)
            {
                a.Grade = "A+";
            }
            if(a.Percent >= 75 && a.Percent<=79)
            {
                a.Grade = "A";
            }
            if(a.Percent >= 70 && a.Percent <=74)
            {
                a.Grade = "A-";
            }
            
            if(a.Percent >= 65 && a.Percent <= 69)
            {
                a.Grade = "B+";
            }

            if(a.Percent >= 60 && a.Percent <= 64)
            {
                a.Grade = "B";
            }

            if(a.Percent >=55 && a.Percent <= 59)
            {
                a.Grade = "B-";
            }

            if(a.Percent >= 50 && a.Percent <= 54)
            {
                a.Grade = "C+";
            }

            if(a.Percent >= 45 && a.Percent <= 49)
            {
                a.Grade = "C";
            }
            if(a.Percent >= 40 && a.Percent <= 44)
            {
                a.Grade = "D";
            }
            if(a.Percent >= 0 && a.Percent <= 39)
            {
                a.Grade = "F";
            }

            
        }
    }
}
