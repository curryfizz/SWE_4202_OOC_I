using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace room_rental
{
    public class Single:Room
    {
        private bool gaming;
        private int qty;

        public void setgaming(bool gaming)
        {
            this.gaming = gaming;
        }

        public bool getgaming()
        {
            return this.gaming;
        }

        

        public int calculatecost()
        {
            if(this.getAC()==true && this.getgaming() == false)
            {
                return 2000 + 500;
            }else if(this.getAC() == false && this.getgaming()==true)
            {
                return 2000 + 1000;
            }else if(this.getAC() == true && this.getgaming() == true)
            {
                return 2000 + 1000 + 500;

            }else
            {
                return 2000;
            }
        }
    }
}
