using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicList.Model
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public Status Created { get; set; }
        public Status Modified { get; set; }
        public Status Approved { get; set; }
        public Status InvoicedReceived { get; set; }
        public Status Cancelled { get; set; }
        public IEnumerable<PurchaseOrderDetails> Details { get; set; }
        public IEnumerable<EmailLog> EmailLogs { get; set; }

    }
}
