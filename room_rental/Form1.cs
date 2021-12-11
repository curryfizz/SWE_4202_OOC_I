using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace room_rental
{
    public partial class room_rentals_frm : Form
    {
        List<Single> singlerooms = new List<Single>();
        List<Double> doublesrooms = new List<Double>();
        public room_rentals_frm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_single_room_btn_Click(object sender, EventArgs e)
        {
            
                /*sing_has_AC_bool.Enabled = false;
                sing_has_gmg_bool.Enabled = false;*/
            
            Single room = new Single();
            room.setname(sing_room_type_choice.Text);
            bool selected = false;
            if(num_single_rooms.Text == "")
            {
                MessageBox.Show("Please add the quantity");
            }else if(sing_room_type_choice.Text == "")
            {
                MessageBox.Show("Please choose a room type or select the checkboxes.");
            }
            else
            {
                selected = true;
            }

            if (selected)
            {
               if(sing_room_type_choice.Text == "")
                {
                    if(sing_has_AC_bool.CheckState == CheckState.Unchecked && sing_has_gmg_bool.CheckState == CheckState.Unchecked)
                    {
                        sing_room_type_choice.Text = "Single Room";
                    }else if(sing_has_AC_bool.CheckState == CheckState.Checked && sing_has_gmg_bool.CheckState == CheckState.Unchecked)
                    {
                        sing_room_type_choice.Text = "Single Room+A/C";
                    }else if(sing_has_AC_bool.CheckState == CheckState.Checked && sing_has_gmg_bool.CheckState == CheckState.Checked)
                    {
                        sing_room_type_choice.Text = "Single Room + A / C + Gaming Setup";
                    }else if(sing_has_AC_bool.CheckState == CheckState.Unchecked && sing_has_gmg_bool.CheckState == CheckState.Checked)
                    {
                        sing_room_type_choice.Text = "Single Room+Gaming Setup";
                    }

                    sing_has_AC_bool.Enabled=false;
                    sing_has_gmg_bool.Enabled = false;
                }
                else
                {
                    sing_has_AC_bool.Enabled=false;
                    sing_has_gmg_bool.Enabled = false;

                }
                string search_room = sing_room_type_choice.Text;
                bool froom = false;
                for(int i = 0; i < singlerooms.Count; i++)
                {
                    if (search_room == singlerooms[i].getname())
                    {
                        froom = true;
                        singlerooms[i].setqty(Convert.ToInt32(num_single_rooms.Text) + singlerooms[i].getqty());
                        room = singlerooms[i];
                        break;
                    }
                }

                if(froom == false)
                {
                    room.setname(search_room);
                    room.setTV(true);
                    room.setbed(1);
                    room.setqty(Convert.ToInt32(num_single_rooms.Text));
                    room.setAC(sing_has_AC_bool.Checked);
                    room.setgaming(sing_has_gmg_bool.Checked);
                    singlerooms.Add(room);
                }
                    int cost = room.calculatecost();
                
                MessageBox.Show("You have entered " + num_single_rooms.Text + " " + sing_room_type_choice.Text + "(s) which cost $" + Convert.ToString(cost) + "/day.");
                sing_room_type_choice.Text = null;
                num_single_rooms.Text = null;
                sing_has_AC_bool.CheckState = CheckState.Unchecked;
                sing_has_gmg_bool.CheckState=CheckState.Unchecked;
                sing_has_AC_bool.Enabled=true;
                sing_has_gmg_bool.Enabled = true;

            }

        }

        private void room_quantity_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void sing_room_type_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sing_room_type_choice.Text == "Single Room")
            {
                sing_has_AC_bool.CheckState = CheckState.Unchecked;
                sing_has_gmg_bool.CheckState = CheckState.Unchecked;
                
            }
            else if (sing_room_type_choice.Text == "Single Room+A/C")
            {
                sing_has_AC_bool.CheckState = CheckState.Checked;
                sing_has_gmg_bool.CheckState = CheckState.Unchecked;

            }
            else if (sing_room_type_choice.Text == "Single Room+A/C+Gaming Setup")
            {
                sing_has_AC_bool.CheckState = CheckState.Checked;
                sing_has_gmg_bool.CheckState = CheckState.Checked;
            }
            else if (sing_room_type_choice.Text == "Single Room+Gaming Setup")
            {
                sing_has_AC_bool.CheckState = CheckState.Unchecked;
                sing_has_gmg_bool.CheckState = CheckState.Checked;
                
            }
            sing_has_AC_bool.Enabled = false;
            sing_has_gmg_bool.Enabled = false;
            
        }

        private void add_dbl_room_Click(object sender, EventArgs e)
        {
            Double room = new Double();
            room.setname(dbl_room_type_choice.Text);
            bool selected = false;
            if(qty_dbl_rooms_txtbox.Text == "")
            {
                MessageBox.Show("Please enter the quantity.");
            }else if(dbl_room_type_choice.Text == "")
            {
                MessageBox.Show("Please choose a room type or select the checkboxes.");
            }
            else
            {
                selected = true;
            }
            if (selected)
            {
                if(dbl_room_type_choice.Text == "")
                {
                    if(dbl_has_ac_bool.CheckState == CheckState.Unchecked && extra_tv_bool.CheckState == CheckState.Unchecked && c_break_bool.CheckState == CheckState.Unchecked)
                    {
                        dbl_room_type_choice.SelectedIndex = 0;
                    }else if(dbl_has_ac_bool.CheckState == CheckState.Checked && extra_tv_bool.CheckState == CheckState.Unchecked && c_break_bool.CheckState == CheckState.Unchecked)
                    {
                        dbl_room_type_choice.SelectedIndex = 1;
                    }
                    else if (dbl_has_ac_bool.CheckState == CheckState.Unchecked && extra_tv_bool.CheckState == CheckState.Checked && c_break_bool.CheckState == CheckState.Unchecked)
                    {
                        dbl_room_type_choice.SelectedIndex = 2;
                    }
                    else if (dbl_has_ac_bool.CheckState == CheckState.Unchecked && extra_tv_bool.CheckState == CheckState.Unchecked && c_break_bool.CheckState == CheckState.Checked)
                    {
                        dbl_room_type_choice.SelectedIndex = 3;
                    }
                    else if (dbl_has_ac_bool.CheckState == CheckState.Checked && extra_tv_bool.CheckState == CheckState.Checked && c_break_bool.CheckState == CheckState.Unchecked)
                    {
                        dbl_room_type_choice.SelectedIndex = 4;
                    }
                    else if (dbl_has_ac_bool.CheckState == CheckState.Checked && extra_tv_bool.CheckState == CheckState.Unchecked && c_break_bool.CheckState == CheckState.Checked)
                    {
                        dbl_room_type_choice.SelectedIndex = 5;
                    }
                    else if (dbl_has_ac_bool.CheckState == CheckState.Checked && extra_tv_bool.CheckState == CheckState.Checked && c_break_bool.CheckState == CheckState.Checked)
                    {
                        dbl_room_type_choice.SelectedIndex = 6;
                    }
                    else if (dbl_has_ac_bool.CheckState == CheckState.Unchecked && extra_tv_bool.CheckState == CheckState.Checked && c_break_bool.CheckState == CheckState.Checked)
                    {
                        dbl_room_type_choice.SelectedIndex = 7;
                    }
                }

                dbl_has_ac_bool.Enabled = false;
                extra_tv_bool.Enabled = false;
                c_break_bool.Enabled = false;
                string search_room = dbl_room_type_choice.Text;
                bool froom = false;
                for (int i = 0; i < doublesrooms.Count; i++)
                {
                    if (search_room == doublesrooms[i].getname())
                    {
                        froom = true;
                        doublesrooms[i].setqty(Convert.ToInt32(qty_dbl_rooms_txtbox.Text) + doublesrooms[i].getqty());
                        room = doublesrooms[i];
                        break;
                    }
                }

                if (froom == false)
                {
                    room.setname(search_room);
                    room.setTV(true);
                    room.setxtraTV(extra_tv_bool.Checked);
                    room.setbed(2);
                    room.setAC(dbl_has_ac_bool.Checked);
                    room.setcbrk(c_break_bool.Checked);
                    room.setqty(Convert.ToInt32(qty_dbl_rooms_txtbox.Text));
                    doublesrooms.Add(room);
                }
                int cost = room.calculatecost();

                MessageBox.Show("You have entered " + dbl_room_type_choice.Text + " " + qty_dbl_rooms_txtbox.Text + " rooms which cost $" + Convert.ToString(cost) + "/day.");
                dbl_room_type_choice.Text = "";
                qty_dbl_rooms_txtbox.Text = "";
                dbl_has_ac_bool.Enabled = true;
                extra_tv_bool.Enabled = true;
                c_break_bool.Enabled = true;

            }
        }

        private void rent_room_btn_Click(object sender, EventArgs e)
        {
            
            string search = all_rooms_choose.Text;

            for(int i = 0; i < doublesrooms.Count; i++)
            {
                if(search == doublesrooms[i].getname())
                {
                    if (doublesrooms[i].getqty() > 0)
                    {
                        doublesrooms[i].setqty(doublesrooms[i].getqty() - Convert.ToInt32(room_quantity_txtbox.Text));
                        MessageBox.Show("Room successfully rented");
                    }
                    else
                    {
                        MessageBox.Show("Room cannot be rented");
                    }
                    break;
                }
            }

            for (int i = 0; i < singlerooms.Count; i++)
            {
                if (search == singlerooms[i].getname())
                {
                    if (singlerooms[i].getqty() > 0)
                    {
                        singlerooms[i].setqty(singlerooms[i].getqty() - Convert.ToInt32(room_quantity_txtbox.Text));
                        MessageBox.Show("Room successfully rented");
                    }
                    else
                    {
                        MessageBox.Show("Room cannot be rented");
                    }
                    break;
                }
            }
        }

        private void show_room_btn_Click(object sender, EventArgs e)
        {
            view_rooms_listbox.Items.Clear();
            string search = combined_room_list.Text;
            view_rooms_listbox.Items.Add("Name \t\t Quantity \t\t Cost");
            bool found = false;
            for (int i = 0; i < doublesrooms.Count; i++)
            {
                if (search == doublesrooms[i].getname())
                {
                    view_rooms_listbox.Items.Add(doublesrooms[i].getname() + "\t" + doublesrooms[i].getqty() + "\t\t$" + doublesrooms[i].calculatecost());
                    found = true;
                    break;
                }
            }

            for (int i = 0; i < singlerooms.Count; i++)
            {
                if (search == singlerooms[i].getname())
                {
                    view_rooms_listbox.Items.Add(singlerooms[i].getname() + "\t" + singlerooms[i].getqty() +"\t\t$"+ singlerooms[i].calculatecost());
                    found=true;
                    break;
                }
            }
            if (found == false)
            {
                view_rooms_listbox.Items.Add(search + "\t N\\A \t\tN\\A");
            }

        }

        private void view_rooms_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dbl_room_type_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dbl_room_type_choice.SelectedIndex == 0)
            {
                dbl_has_ac_bool.CheckState = CheckState.Unchecked;
                extra_tv_bool.CheckState= CheckState.Unchecked;
                c_break_bool.CheckState= CheckState.Unchecked;
            }else if(dbl_room_type_choice.SelectedIndex == 1)
            {
                dbl_has_ac_bool.CheckState = CheckState.Checked;
                extra_tv_bool.CheckState= CheckState.Unchecked;
                c_break_bool.CheckState= CheckState.Unchecked;
                

            }else if (dbl_room_type_choice.SelectedIndex == 2)
            {
                dbl_has_ac_bool.CheckState = CheckState.Unchecked;
                extra_tv_bool.CheckState= CheckState.Checked;
                c_break_bool.CheckState= CheckState.Unchecked;

            }else if (dbl_room_type_choice.SelectedIndex == 3)
            {
                dbl_has_ac_bool.CheckState = CheckState.Unchecked;
                extra_tv_bool.CheckState= CheckState.Unchecked;
                c_break_bool.CheckState= CheckState.Checked;

            }else if(dbl_room_type_choice.SelectedIndex== 4)
            {
                dbl_has_ac_bool.CheckState = CheckState.Checked;
                extra_tv_bool.CheckState= CheckState.Checked;
                c_break_bool.CheckState= CheckState.Unchecked;
            }else if (dbl_room_type_choice.SelectedIndex == 5)
            {
                dbl_has_ac_bool.CheckState = CheckState.Checked;
                extra_tv_bool.CheckState= CheckState.Unchecked;
                c_break_bool.CheckState= CheckState.Checked;

            }else if(dbl_room_type_choice.SelectedIndex == 6)
            {
                dbl_has_ac_bool.CheckState = CheckState.Checked;
                extra_tv_bool.CheckState= CheckState.Checked;
                c_break_bool.CheckState= CheckState.Checked;


            }else if(dbl_room_type_choice.SelectedIndex == 7)
            {

                dbl_has_ac_bool.CheckState = CheckState.Unchecked;
                extra_tv_bool.CheckState= CheckState.Checked;
                c_break_bool.CheckState= CheckState.Checked;

            }
                dbl_has_ac_bool.Enabled = false;
                extra_tv_bool.Enabled = false;
                c_break_bool.Enabled = false;

        }
    }
}
