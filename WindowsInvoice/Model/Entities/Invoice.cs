using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Invoice
    {
        public int id { get; set; }
        public Customer customer { get; set; }
        public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateSent { get; set; }

    }
}
