using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicList.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
        public User ApprovedBy { get; set; }
        public Vat Vat { get; set; }
        public IEnumerable<PurchaseOrder> PurchaseOrders { get; set;}


    }
}
