using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_dependencies
{
    public class Rent
    {
        Users renting_user = new Users();
        Cars rented_car = new Cars();
       
        public void set_renting_user(Users user)
        {
            this.renting_user = user;
        }
        public void set_rented_car(Cars car)
        {
            this.rented_car = car;
        }

        public Users getrenting_userinfo()
        {
            return this.renting_user;
        }

        public Cars getrented_carinfo()
        {
            return this.rented_car;
        }


        public string getrentinfo()
        {
            return renting_user.getusername() + "\n" + renting_user.getuseraddress() + "\n" + rented_car.getcarmodel() + "\n" +renting_user.getuserdestination();
        }
        
    }
}
