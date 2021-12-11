using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_dependencies
{
    public class Users
    {
        private int userId;
        private string username;
        private string useraddress;
        private string userdestination;


        public int getuserid()
        {
            return userId;
        }
        public void setid(int userID)
        {
            this.userId = userID;
        }


        public string getusername()
        {
            return this.username;
        }

        public void setusername(string username)
        {
            this.username = username;
        }
        public string getuseraddress()
        {
            return this.useraddress;
        }

        public void setuseraddress(string address)
        {
            this.useraddress = address;
        }
        public string getuserdestination()
        {
            return this.userdestination;
        }

        public void setuserdestination(string destination)
        {
            this.userdestination = destination;
        }





    }
}
