using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOfHouseSystem
{
    class Order
    {
        public int orderID { get; set; }
        public int userID { get; set; }
        public int orderLinesID { get; set; }
        public int transactionID { get; set; }
        public string orderDate { get; set; }


    }
}
