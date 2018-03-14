using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOfHouseSystem
{
    class Orderlines
    {
        public int OrderLinesID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
