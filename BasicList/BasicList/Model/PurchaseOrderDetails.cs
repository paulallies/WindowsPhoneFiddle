using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicList.Model
{
    public class PurchaseOrderDetails
    {
        public int Line { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
    }
}
