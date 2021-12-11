using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_dependencies;
namespace Car_rental_system
{
    public partial class car_rental_system : Form
    {
        List<Users> userdata = new List<Users>();
        List<Cars> carsdata = new List<Cars>();
        List<Rent> rentsdata = new List<Rent>();
        
        public car_rental_system()
        {
            InitializeComponent();
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void user_id_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_user_btn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            if (user_name_textbox.Text == "" || user_id_textbox.Text == "" || user_address_textbox.Text == "" || user_destination_textbox.Text == ""){
                MessageBox.Show("Please enter all details!");
            }else
            {
                int id = Convert.ToInt32(user_id_textbox.Text);
                bool duplicate_id = false;
                for(int i=0; i<userdata.Count; i++)
                {
                    if(id == userdata[i].getuserid())
                    {
                        duplicate_id = true;
                        MessageBox.Show("ID already exists. Please try again with another id!");
                        break;
                    }
                    
                }
                if (duplicate_id == false)
                {

                    u.setid(id);
                    u.setusername(user_name_textbox.Text);
                    u.setuseraddress(user_address_textbox.Text);
                    u.setuserdestination(user_destination_textbox.Text);
                    userdata.Add(u);
                    MessageBox.Show("User saved successfully");
                    user_name_textbox.Text = "";
                    user_id_textbox.Text = "";
                    user_address_textbox.Text = "";
                    user_destination_textbox.Text = "";

                }

            }
        }

        private void savecar_btn_Click(object sender, EventArgs e)
        {
            if(car_name_textbox.Text == "" || car_model_textbox.Text == "" || num_cars_textbox.Text == "")
            {
                MessageBox.Show("Please fill in all details.");
            }
            else
            {
                bool duplicate_car = false;
                string name = car_name_textbox.Text;
                for(int i=0; i<carsdata.Count; i++)
                {
                    if(carsdata[i].getcarname() == name)
                    {
                        carsdata[i].setcarquantity(Convert.ToInt32(num_cars_textbox.Text) + carsdata[i].getcaramount());
                        car_model_textbox.Text = carsdata[i].getcarmodel();
                        duplicate_car = true;
                        MessageBox.Show("Car quantity updated successfully");
                        car_name_textbox.Text = "";
                        car_model_textbox.Text = "";
                        num_cars_textbox.Text = "";

                        break;
                    }
                }
                if (duplicate_car == false)
                {
                    Cars cars = new Cars();
                    cars.setcarname(car_name_textbox.Text);
                    cars.setcarmodel(car_model_textbox.Text);
                    cars.setcarquantity(Convert.ToInt32(num_cars_textbox.Text));
                    carsdata.Add(cars);
                    MessageBox.Show("Car saved successfully");
                    car_name_textbox.Text = "";
                    car_model_textbox.Text = "";
                    num_cars_textbox.Text = "";
                }
            }
        }

        private void num_cars_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rent_car_btn_Click(object sender, EventArgs e)
        {
            if(rent_uid_textbox.Text == "" || rent_cname_textbox.Text == "")
            {
                MessageBox.Show("Please fill in all details!");
            }
            else
            {

                int id = Convert.ToInt32(rent_uid_textbox.Text);
                string name = rent_cname_textbox.Text;
                Users users = new Users();
                Cars car = new Cars();
                bool user_found = false, car_found = false;
                bool ren = true;
                for(int i=0; i<userdata.Count; i++)
                {
                    if(userdata[i].getuserid() == id)
                    {
                        users = userdata[i];
                        user_found = true;
                        break;
                    }
                }
                for(int i=0; i<carsdata.Count; i++)
                {
                    if(String.Equals(name, carsdata[i].getcarname()))
                    {
                        car = carsdata[i];
                        int a = carsdata[i].getcaramount();
                        if (a == 0)
                        {
                            MessageBox.Show("Car cannot be rented");
                            ren = false;
                            break;
                        }
                        carsdata[i].setcarquantity(a-1);
                        car_found = true;
                    }
                }

                if (!user_found)
                {
                    MessageBox.Show("User not found!");
                }
                else if(!user_found && !car_found)
                {
                    MessageBox.Show("User and Car not found!");
                }else if (!car_found)
                {
                    MessageBox.Show("Car not found!");
                }


                if(ren == true)
                {

                    Rent r = new Rent();
                    r.set_renting_user(users);
                    r.set_rented_car(car);
                    rentsdata.Add(r);
                    MessageBox.Show("Car rented successfully");
                    rent_cname_textbox.Text = "";
                    rent_uid_textbox.Text = "";
                }
            }
        }

        private void rent_cname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_user_his_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(user_his_id_textbox.Text);
            Users a = new Users();
            bool find = false;
            uhis_listbox.Items.Clear();
            for(int i=0; i<rentsdata.Count; i++)
            {
                if (rentsdata[i].getrenting_userinfo().getuserid() == id)
                {
                    find = true;
                    uhis_listbox.Items.Add(rentsdata[i].getrenting_userinfo().getusername());
                    uhis_listbox.Items.Add(" ");
                    uhis_listbox.Items.Add(rentsdata[i].getrenting_userinfo().getuseraddress());
                    uhis_listbox.Items.Add(" ");
                    uhis_listbox.Items.Add(rentsdata[i].getrented_carinfo().getcarname());
                    uhis_listbox.Items.Add(" ");
                    uhis_listbox.Items.Add(rentsdata[i].getrenting_userinfo().getuserdestination());
                    break;
                }

            }

            if (find == false)
            {
                MessageBox.Show("User has not been added or rented a car.");
            }
        }

        private void show_car_his_btn_Click(object sender, EventArgs e)
        {
            string c = carhis_carname_textbox.Text;
            car_his_listbox.Items.Clear();
            bool find = false;
            for(int i=0; i<carsdata.Count; i++)
            {
                if(c == carsdata[i].getcarname())
                {
                    string a = carsdata[i].getcarmodel();
                    find = true;
                    string b = Convert.ToString(carsdata[i].getcaramount());
                    car_his_listbox.Items.Add(a);
                    car_his_listbox.Items.Add(" ");
                    car_his_listbox.Items.Add(b);
                }
            }

            if (!find)
            {
                MessageBox.Show("Car cannot be found!");
            }
        }
    }
}
