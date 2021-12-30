using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class LaundryMS
    {
        
        List<User> users = new List<User>();
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        List<Orders> orders = new List<Orders>();
        public List<Orders> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        Owner owner = new Owner();
        public Owner Owner
        {
            get { return owner;}
            set { owner = value; }

        }

        private int orderid = 0;
        public int Orderid
        {
            get { return orderid;}
            set { orderid = value; }
        }
    }
}
