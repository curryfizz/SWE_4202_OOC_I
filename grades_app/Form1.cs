using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_task_1_200042134
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void calculategrades_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void nametextbox(object sender, EventArgs e)
        {
            
        }

        private void calculategradebutton_Click(object sender, EventArgs e)
        {
            if(_nametxtbox.Text == "" || studentidtextbox.Text == "" || semestertextbox.Text == "" || quizonetextbox.Text == "" || quiztwotextbox.Text == "" || quizthreetextbox.Text == "" || quizfourtextbox.Text == "" || attendancetextbox.Text == "" || midtextbox.Text == "" || finaltextbox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                int[] quizmarks = new int[4];
                quizmarks[0] = Convert.ToInt32(quizonetextbox.Text);
                quizmarks[1] = Convert.ToInt32(quiztwotextbox.Text);
                quizmarks[2] = Convert.ToInt32(quizthreetextbox.Text);
                quizmarks[3] = Convert.ToInt32(quizfourtextbox.Text);
                for(int i=0; i<4; i++) 
                {
                    for(int j=i+1; j<4; j++)
                    {
                        int temp = quizmarks[i];
                        if (quizmarks[i] < quizmarks[j])
                        {
                            quizmarks[i] = quizmarks[j];
                            quizmarks[j] = temp;
                        }
                    }
                }
                quizmarksoutput.Text = Convert.ToString(quizmarks[0] + quizmarks[1] + quizmarks[2])+"/45";
                finalmarksoutput.Text = finaltextbox.Text + "/150";
                Double att = Convert.ToDouble(attendancetextbox.Text);
                att = Math.Round((att * 30) / 28);
                int mid = Convert.ToInt32(midtextbox.Text);
                int quiz = quizmarks[0] + quizmarks[1] + quizmarks[2];
                int fin = Convert.ToInt32(finaltextbox.Text);
                int tot = Convert.ToInt32(att) + mid + quiz + fin;
                totalmarksoutput.Text = Convert.ToString(att+mid+quiz+fin) + "/300";
                attendancemarksoutput.Text = Convert.ToString(att) + "/30";
                midmarksoutput.Text = midtextbox.Text + "/75";
                string g;
                if(tot>=240 && tot<= 300)
                {
                    g = "A+";
                }else if(tot>=225 && tot<= 240)
                {
                    g = "A";
                }else if(tot>=210 && tot <= 225)
                {
                    g = "A-";
                }else if(tot>=195 && tot <= 210)
                {
                    g = "B+";
                }else if(tot>=180 && tot <= 195)
                {
                    g = "B";
                }else if(tot>=165 && tot <= 180)
                {
                    g = "B-";
                }else if(tot >=150 && tot <= 165)
                {
                    g = "C+";
                }else if( tot>=135 && tot <= 150)
                {
                    g = "C";
                }else if(tot>=120 && tot <= 135)
                {
                    g = "D";
                }
                else
                {
                    g = "F";
                }
                gradeoutput.Text = g;
                outputpercentage.Text = _nametxtbox.Text + " obtained " + Convert.ToString((tot*100)/300) + "% marks.";

            }
        }

        private void attendancemarksoutput_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputpercentage_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void quizonetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void quizfourtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quizthreetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void quiztwotextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
