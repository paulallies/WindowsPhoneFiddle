using Model.DataContexts;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly InvoiceDataContext db;

        public CustomerRepository() {
            db = new InvoiceDataContext();
        }

        public Customer AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void deleteCustomer(Customer customer)
        {
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        public Customer updateCustomer(Customer customer)
        {
            
            db.Entry(customer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Entities.Customer> getAllCustomers()
        {
            return db.Customers.AsEnumerable();
        }

        public Customer getOneCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);
            return customer;
        }
    }
}
