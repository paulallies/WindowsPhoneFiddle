using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class InvoiceDetail
    {
        public Invoice invoice { get; set; }
        public int qty { get; set; }
        public decimal unitprice { get; set; }
        public string description { get; set; }
    }
}
