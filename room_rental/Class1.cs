using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace room_rental
{
    public class Room
    {
        private string name;
        private bool TV;
        private bool fridge;
        private int bed;
        private int qty;
        private bool AC;
        private int cost;


        public void setname(string name)
        {
            this.name = name;
        }

        public string getname()
        {
            return this.name;
        }

        public void setTV(bool TV)
        {
            this.TV = TV;
        }

        public bool getTV()
        {
            return TV;
        }

        public void setfridge(bool fridge)
        {
            this.fridge = fridge;
        }

        public bool getfridge()
        {
            return TV;
        }

        public void setbed(int bed)
        {
            this.bed = bed;
        }

        public void setAC(bool Ac)
        {
            this.AC = Ac;
        }

        public bool getAC()
        {
            return this.AC;
        }


        public void setqty(int qty)
        {
            this.qty = qty;
        }

        public int getqty()
        {
            return this.qty;
        }
    }
}
