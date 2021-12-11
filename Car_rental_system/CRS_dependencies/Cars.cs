using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_dependencies
{
    public class Cars
    {
        private string carName;
        private string carmodel;
        private int numCars;
        public void setcarname(string name)
        {
            this.carName = name;

        }

        public void setcarmodel(string mod)
        {
            this.carmodel = mod;
        }

        public void setcarquantity(int ncar)
        {
            this.numCars = ncar;
        }

        public string getcarname()
        {
            return carName;
        }

        public string getcarmodel()
        {
            return carmodel;
        }
        public int getcaramount()
        {
            return numCars;
        }
    }
}
