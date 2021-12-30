using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LMS : Form
    {
        
        static bool checknull(string a)
        {
            if(a== null || a == "")
            {

                return false;
            }

            return true;
        }
        

        static void nullalrt()
        {
            MessageBox.Show("Please fill in all details!");
        }

        LaundryMS Laundry = new LaundryMS();
        
        public LMS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ordr_shts_typ_cmb_bx.SelectedIndex = 0;
            ordr_shrt_typ_cmb_bx.SelectedIndex=0;
            ordr_pnt_typ_txt_bx.SelectedIndex = 0;
            ordr_suits_typ_txt_bx.SelectedIndex = 0;
            Laundry.Owner.Balance = 0;
            

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usr_crt_acc_btn_Click(object sender, EventArgs e)
        {
            bool checkforid = false;
            bool checkforname = checknull(acc_usr_nm_txt_bx.Text);
            bool checkforaddress = checknull(acc_usr_addrs_txt_bx.Text);
            bool checkforuid = checknull(acc_usr_id_txt_bx.Text);
            for(int i=0; i<Laundry.Users.Count; i++)
            {
                if(Laundry.Users[i].Userid == acc_usr_id_txt_bx.Text && checkforuid==true)
                {
                    MessageBox.Show("ID already exists please try using another id!");
                    checkforid = true;
                    break;
                }
            }

            
            if (!checkforid)
            {

                if (checkforuid == true && checkforname == true && checkforaddress == true)
                {
                    User u = new User();
                    u.Userid = acc_usr_id_txt_bx.Text;
                    u.Name = acc_usr_nm_txt_bx.Text;
                    u.Address = acc_usr_addrs_txt_bx.Text;
                    Laundry.Users.Add(u);
                    MessageBox.Show("User added successfully!");
                    acc_usr_addrs_txt_bx.Text = "";
                    acc_usr_id_txt_bx.Text = "";
                    acc_usr_nm_txt_bx.Text = "";

                }
                else
                {
                    nullalrt();
                }
            }
        }

        private void plc_ordr_btn_Click(object sender, EventArgs e)
        {
            bool checkforid = false;
            User u = new User();    
            bool checkforuid = checknull(ordr_usr_id_txt_bx.Text);
            int indexofuser = -1; 
            bool checkforshrtqty = checknull(ordr_shrt_qty_txt_bx.Text);
            bool checkforpntqty = checknull(ordr_pnts_qty_txt_bx.Text);
            bool checkforsuitsqty = checknull(ordr_suits_qty_txt_bx.Text);
            bool checkforbsheetsqty = checknull(ordr_bshts_qty_txt_bx.Text);

            for(int i=0; i<Laundry.Users.Count; i++)
            {
                
                if(Laundry.Users[i].Userid.Equals(ordr_usr_id_txt_bx.Text) && checkforuid==true)
                {
                    u = Laundry.Users[i];
                    checkforid = true;
                    indexofuser = i;
                    break;
                }
            }

            if (!checkforid && checkforuid == true)
            {
                MessageBox.Show("User doesn't exist!");
            }
            else
            {
                if(checkforuid ==true && (checkforshrtqty==true || checkforpntqty == true || checkforsuitsqty ==  true || checkforbsheetsqty == true))
                {
                    Orders orders = new Orders();
                    int shrtprice, pantprice, suitprice, bsheetsprice;

                    orders.Orderid = Convert.ToString(Laundry.Orderid);
                    Laundry.Orderid++;

                    orders.Pants.Quantity = (!checkforpntqty ? 0 : Convert.ToInt32(ordr_pnts_qty_txt_bx.Text));
                    orders.Shirt.Quantity = (!checkforshrtqty ? 0 : Convert.ToInt32(ordr_shrt_qty_txt_bx.Text));
                    orders.Suits.Quantity = (!checkforsuitsqty ? 0 : Convert.ToInt32(ordr_suits_qty_txt_bx.Text));
                    orders.BedSheets.Quantity = (!checkforbsheetsqty ? 0 : Convert.ToInt32(ordr_bshts_qty_txt_bx.Text));
                    shrtprice = Staticmethods.returnshirtprice(ordr_shrt_typ_cmb_bx.SelectedIndex);
                    pantprice = Staticmethods.returnpantprice(ordr_pnt_typ_txt_bx.SelectedIndex);
                    suitprice = Staticmethods.returnsuitsprice(ordr_suits_typ_txt_bx.SelectedIndex);
                    bsheetsprice = Staticmethods.returnsheetsprice(ordr_shts_typ_cmb_bx.SelectedIndex);
                    orders.Shirt.Subtotal= Staticmethods.calculate(orders.Shirt.Quantity, shrtprice);
                    orders.Pants.Subtotal= Staticmethods.calculate(orders.Pants.Quantity, pantprice);
                    orders.Suits.Subtotal= Staticmethods.calculate(orders.Suits.Quantity, suitprice);
                    orders.BedSheets.Subtotal= Staticmethods.calculate(orders.BedSheets.Quantity, bsheetsprice);
                    orders.Pants.ToDo = ordr_pnt_typ_txt_bx.Text;
                    orders.Shirt.ToDo = ordr_shrt_typ_cmb_bx.Text;
                    orders.Suits.ToDo = ordr_suits_typ_txt_bx.Text;
                    orders.BedSheets.ToDo = ordr_shts_typ_cmb_bx.Text;

                    orders.Ordertotal = orders.Shirt.Subtotal + orders.Pants.Subtotal + orders.Suits.Subtotal + orders.BedSheets.Subtotal;
                    Laundry.Owner.Balance = Laundry.Owner.Balance + orders.Ordertotal;
                    //MessageBox.Show(Convert.ToString(Laundry.Owner.Balance));
                   // MessageBox.Show(Convert.ToString(orders.Pants.Subtotal) + "\t" + Convert.ToString(orders.Shirt.Subtotal) + "\t" + Convert.ToString(orders.Suits.Subtotal) + "\t" + Convert.ToString(orders.BedSheets.Subtotal) + "\n" + Convert.ToString(orders.Ordertotal));
                    Laundry.Users[indexofuser].Orders.Add(orders);
                   
                    MessageBox.Show("Order placed successfully!\nOrder id is " + orders.Orderid + " and total is BDT." + Convert.ToString(orders.Ordertotal) + ". ");
                    ordr_bshts_qty_txt_bx.Text = "";
                    ordr_pnts_qty_txt_bx.Text = "";
                    ordr_shrt_qty_txt_bx.Text = "";
                    ordr_suits_qty_txt_bx.Text = "";
                    ordr_usr_id_txt_bx.Text = "";
                    ordr_shts_typ_cmb_bx.SelectedIndex = 0;
                    ordr_shrt_typ_cmb_bx.SelectedIndex=0;
                    ordr_pnt_typ_txt_bx.SelectedIndex = 0;
                    ordr_suits_typ_txt_bx.SelectedIndex = 0;


                }
                else
                {
                    nullalrt();
                }
            }

        }

        private void ordr_status_btn_Click(object sender, EventArgs e)
        {
            bool ordrfound = false;
            for(int i = 0; i <Laundry.Users.Count; i++)
            {
                
                for(int j=0; j<Laundry.Users[i].Orders.Count; j++)
                {

                    if(ownr_ordr_id_txt_bx.Text == Laundry.Users[i].Orders[j].Orderid)
                    {
                        ordrfound = true;
                        if(Laundry.Users[i].Orders[j].Orderstatus == "Delivered")
                        {
                            MessageBox.Show("Order has been delivered!");
                            break;
                        }
                        else
                        {

                            Laundry.Users[i].Orders[j].Orderstatus = ownr_ordr_sts_cmb_bx.Text;
                            curr_balance_lbl.Text = "Current Balance: " + Convert.ToString(Laundry.Owner.Balance);
                            MessageBox.Show("Order Status changed successfully");
                            break;
                        }
                    }
                }

                if (ordrfound) break;
            }
            if (!ordrfound)
            {
                MessageBox.Show("Order is not found! Please try again.");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void see_order_details_btn_Click(object sender, EventArgs e)
        {

            bool orderfound = false;
            for(int i = 0;i< Laundry.Users.Count; i++)
            {
                for(int j=0; j<Laundry.Users[i].Orders.Count; j++)
                {
                    if(status_ordr_id_txt_bx.Text == Laundry.Users[i].Orders[j].Orderid)
                    {
                        order_status_listbox.Items.Clear();
                        orderfound = true;
                        ordr_status_check_status_label.Text = "Status: " + Laundry.Users[i].Orders[i].Orderstatus;
                        order_status_check_amount_label.Text = "Amount: " + Convert.ToString(Laundry.Users[i].Orders[i].Ordertotal);
                        order_staus_name_label.Text = "Name: " + Laundry.Users[i].Name;
                        order_status_check_address_lbl.Text = "Address: " + Laundry.Users[i].Address;
                        string listhead = "Type\t\tQuantity\tTo_Do\tAmount";
                        string border = "----------------------------------------------------------";
                        order_status_listbox.Items.Add(listhead);
                        order_status_listbox.Items.Add(border);
                        if(Laundry.Users[i].Orders[j].Shirt.Quantity != 0)
                        {
                            string shirt = (Laundry.Users[i].Orders[j].Shirt.Quantity == 1 ? "Shirt" : "Shirts") + "\t\t" + Convert.ToString(Laundry.Users[i].Orders[j].Shirt.Quantity) + "\t" + Laundry.Users[i].Orders[j].Shirt.ToDo + "\t" + Convert.ToString(Laundry.Users[i].Orders[j].Shirt.Subtotal);
                            order_status_listbox.Items.Add(shirt);
                        }
                        if(Laundry.Users[i].Orders[j].Pants.Quantity != 0)
                        {
                            string pant = (Laundry.Users[i].Orders[j].Pants.Quantity == 1 ? "Pant" : "Pants") + "\t\t" + Convert.ToString(Laundry.Users[i].Orders[j].Pants.Quantity) + "\t" + Laundry.Users[i].Orders[j].Pants.ToDo + "\t" + Convert.ToString(Laundry.Users[i].Orders[j].Pants.Subtotal);
                            order_status_listbox.Items.Add(pant);
                        }
                        if(Laundry.Users[i].Orders[j].Suits.Quantity != 0)
                        {
                            string suit = (Laundry.Users[i].Orders[j].Suits.Quantity == 1 ? "Suit" : "Suits") + "\t\t" + Convert.ToString(Laundry.Users[i].Orders[j].Suits.Quantity) + "\t" + Laundry.Users[i].Orders[j].Suits.ToDo + "\t" + Convert.ToString(Laundry.Users[i].Orders[j].Suits.Subtotal);
                            order_status_listbox.Items.Add(suit);
                        }
                        if(Laundry.Users[i].Orders[j].BedSheets.Quantity != 0)
                        {
                            string sheet = (Laundry.Users[i].Orders[j].Shirt.Quantity == 1 ? "Bedsheet" : "Bedsheets") + "\t" + Convert.ToString(Laundry.Users[i].Orders[j].BedSheets.Quantity) + "\t" + Laundry.Users[i].Orders[j].BedSheets.ToDo + "\t" + Convert.ToString(Laundry.Users[i].Orders[j].BedSheets.Subtotal);
                            order_status_listbox.Items.Add(sheet);
                        }



                        break;

                    }
                }
                if (orderfound)
                {
                    break;
                }
            }


            if (!orderfound) MessageBox.Show("Order id not found!");
        }

        private void status_ordr_id_txt_bx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ordr_status_check_status_label_Click(object sender, EventArgs e)
        {

        }

        private void ownr_ordr_sts_cmb_bx_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void ownr_ordr_id_txt_bx_TextChanged(object sender, EventArgs e)
        {
            bool ordrfound = false;
            for(int i = 0; i <Laundry.Users.Count; i++)
            {
                
                for(int j=0; j<Laundry.Users[i].Orders.Count; j++)
                {

                    if(ownr_ordr_id_txt_bx.Text == Laundry.Users[i].Orders[j].Orderid)
                    {
                        ordrfound = true;


                        ownr_ordr_sts_cmb_bx.Text = Laundry.Users[i].Orders[j].Orderstatus;
                       
                        break;
                        
                    }
                }

                if (ordrfound) break;
            }
            if (!ordrfound) ownr_ordr_sts_cmb_bx.SelectedIndex = -1;
        }

        
    }
}
