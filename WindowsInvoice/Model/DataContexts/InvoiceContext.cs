using System.Data.Entity;
using Model.Entities;

namespace Model.DataContexts
{
    public class InvoiceContext : DbContext
    {


        public InvoiceContext() : base("name=InvoiceContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
