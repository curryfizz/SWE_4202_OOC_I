using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace room_rental
{
    public class Double:Room
    {
        private bool xtraTV;
        private bool cbrk;

        public void setxtraTV(bool xtraTV)
        {
            this.xtraTV = xtraTV;
        }

        public bool getxtraTV()
        {
            return this.xtraTV;
        }

        public void setcbrk(bool cbrk)
        {
            this.cbrk = cbrk;
        }

        public bool getcbrk()
        {
            return this.cbrk;
        }


        public int calculatecost()
        {
            if (this.getAC() == true && this.getxtraTV() == false && this.getcbrk() == false)
            {
                return 3500+500;
            }
            else if (this.getAC() == true && this.getxtraTV() == true && this.getcbrk() == false)
            {
                return 3500 + 500+1000;
            }
            else if (this.getAC() == true && this.getxtraTV() == true && this.getcbrk() == true)
            {
                return 3500+1000+500+500;

            }else if(this.getAC() == false && this.getxtraTV() == true && this.getcbrk() == false)
            {
                return 3500 + 1000;
            }else if(this.getAC() == false && this.getxtraTV() == true && this.getcbrk() == true)
            {
                return 3500 + 1000 + 500;
            }else if(this.getAC() == false && this.getxtraTV() == false && this.getcbrk() == false)
            {
                return 3500 + 500;
            }else if(this.getAC() == true && this.getxtraTV() == false && this.getcbrk() == true)
            {
                return 3500 + 500 + 500;
            }
            else 
            {
                return 3500;
            }
        }
    }
}
