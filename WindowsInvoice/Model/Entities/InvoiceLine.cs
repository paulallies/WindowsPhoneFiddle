using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entities
{
    public class InvoiceLine
    {
        public int line { get; set; }
        public int qty { get; set; }
        public string description { get; set; }
        public decimal unitprice { get; set; }

    }
}
