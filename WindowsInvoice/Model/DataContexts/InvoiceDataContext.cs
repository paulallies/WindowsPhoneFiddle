using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataContexts
{
    public class InvoiceDataContext: DataContext
    {
        public InvoiceDataContext() : base("name=invoicecontext") { }

        public DbSet<Customer> Customers { get; set; }
       
    }
}
