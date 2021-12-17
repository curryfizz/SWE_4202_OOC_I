using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_managementsystem
{
    internal class Drug
    {
        private string drug_name;
        private int drug_quantity;
        private double drug_price;
        private double drug_cost;

        public void setdrug_name(string drug_name)
        {
            this.drug_name = drug_name;
        }

        public string getdrug_name()
        {
            return this.drug_name;
        }

        public void setdrug_quantity(int qty)
        {
            this.drug_quantity=qty;
        }

        public int getdrug_quantity()
        {
            return this.drug_quantity;
        }

        public void setdrug_cost(double cost)
        {
            this.drug_cost=cost;
        }

        public double getdrug_cost()
        {
            return this.drug_cost;
        }
        public void setdrug_price(double price)
        {
            this.drug_price=price;
        }

        public double getdrug_price()
        {
            return this.drug_price;
        }


    }
}
