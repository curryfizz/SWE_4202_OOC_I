using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_managementsystem
{
    public partial class Pharmacy_management_system : Form
    {
        List<Drug> druginfo = new List<Drug>();
        List<string> drugnames = new List<string>();
        double balance = 10000;
        public Pharmacy_management_system()
        {
            InitializeComponent();
        }

        private void Pharmacy_management_system_Load(object sender, EventArgs e)
        {

        }

        private void add_or_update_drug_infobtn_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug();
            bool found_drug = false;
            if (ordr_qty_txt_bx.Text == "" || ordr_rtl_prc_cmb_bx.Text == "" || ordr_cst_prce_txt_bx.Text == "" || ordr_rtl_prc_cmb_bx.Text == "")
            {
                MessageBox.Show("Please fill in all details!");
            }
            else
            {
                for(int i = 0; i < druginfo.Count; i++)
                {
                    if(ord_rdrug_name_cmb_bx.Text == druginfo[i].getdrug_name())
                    {
                        found_drug = true;
                        ordr_cst_prce_txt_bx.Enabled = false;
                        ordr_rtl_prc_cmb_bx.Enabled = false;
                        druginfo[i].setdrug_quantity(druginfo[i].getdrug_quantity() + Convert.ToInt32(ordr_qty_txt_bx.Text));
                        MessageBox.Show("Drug details updated successfully.");
                        break;
                    }
                }

                if(found_drug == false)
                {
                    if(ord_rdrug_name_cmb_bx.Text != "")
                    {
                        drug.setdrug_name(ord_rdrug_name_cmb_bx.Text);
                        int qty = Convert.ToInt32(ordr_qty_txt_bx.Text);
                        if(qty > 0)
                        {
                            drug.setdrug_quantity(qty);
                            double cost = Convert.ToDouble(ordr_cst_prce_txt_bx.Text);
                            if (cost > 0)
                            {
                                if (balance == 0)
                                {
                                    MessageBox.Show("Balance is too low; drug cannot be purchased!");
                                }
                                else
                                {
                                    balance-= (cost*qty);
                                    drug.setdrug_price(cost);
                                    double price = Convert.ToDouble(ordr_rtl_prc_cmb_bx.Text);
                                    if(price > 0)
                                    {
                                        drug.setdrug_price(price);
                                        druginfo.Add(drug);
                                        ord_rdrug_name_cmb_bx.Items.Add(ord_rdrug_name_cmb_bx.Text);
                                        sell_drg_cmb_bx.Items.Add(ord_rdrug_name_cmb_bx.Text);
                                        MessageBox.Show("Drug details added successfully");
                                        ord_rdrug_name_cmb_bx.Text = "";
                                        ordr_qty_txt_bx.Text = "";
                                        ordr_rtl_prc_cmb_bx.Text = "";
                                        ordr_cst_prce_txt_bx.Text = "";
                                
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter a price greater than 0!");
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter a cost greater than 0!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a quantity greater than 0!");
                        }
                    }


                }

            }

        }

        private void ord_rdrug_name_cmb_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void sell_drug_btn_Click(object sender, EventArgs e)
        {
            if(sell_drg_cmb_bx.Text == "" || sell_drug_qty_text_bx.Text == "")
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                for(int i=0;i<druginfo.Count;i++)
                {
                    if(sell_drg_cmb_bx.Text == druginfo[i].getdrug_name())
                    {
                        int qty = Convert.ToInt32(sell_drug_qty_text_bx.Text);
                        int inv = druginfo[i].getdrug_quantity();
                        if(qty > 0) 
                        {
                            if(inv< qty)
                            {
                                MessageBox.Show("Only "+ Convert.ToString(qty) + " units available!");
                                break;
                            }
                            else
                            {
                                double ppu = Convert.ToDouble(druginfo[i].getdrug_price());
                                balance += (ppu * qty);
                                druginfo[i].setdrug_quantity(inv - qty);
                                sell_drug_bill_txt_bx.Text = Convert.ToString(qty * ppu);
                            
                                MessageBox.Show(sell_drug_qty_text_bx.Text + " " + sell_drg_cmb_bx.Text + "(s) sold for BDT." + sell_drug_bill_txt_bx.Text +  " successfully!");
                                sell_drg_cmb_bx.SelectedIndex = -1;
                                sell_drug_bill_txt_bx.Text = "";
                                sell_drug_invntry_txt_bx.Text = "";
                                sell_drug_per_unit_prc_txt_bx.Text = "";
                                sell_drug_qty_text_bx.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter quantity greater than 0");
                        }
                            break;
                    }
                }

            }
        }

        private void sell_drg_cmb_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < druginfo.Count; i++)
            {
                if(sell_drg_cmb_bx.Text == druginfo[i].getdrug_name())
                {
                    sell_drug_per_unit_prc_txt_bx.Text = Convert.ToString(druginfo[i].getdrug_price());
                    sell_drug_invntry_txt_bx.Text = Convert.ToString(druginfo[i].getdrug_quantity());

                }
            }
        }

        private void view_blnce_txt_bx_Click(object sender, EventArgs e)
        {
            curr_balance_txt_bx.Text = Convert.ToString(balance);
        }
    }
}
