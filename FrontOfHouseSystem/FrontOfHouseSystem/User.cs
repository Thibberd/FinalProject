using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOfHouseSystem
{
    public class User
    {
        public int userID { get; set; }
        public int userType { get; set; }
        public String firstname { get; set; }
        public String secondname { get; set; }
        public int PIN { get; set; }

        public String  Username
        {
            get // creates user name to be displayed
            {
                return $"{firstname} {secondname} ";
            }
        }
    }
}
