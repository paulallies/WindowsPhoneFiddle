using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Invoice
    {
        public int id { get; set; }
        public DateTime invoicedate { get; set; }
        public IList<InvoiceLine> MyProperty { get; set; }
    }
}