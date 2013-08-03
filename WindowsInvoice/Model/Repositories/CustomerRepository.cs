using Model.Entities;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> getAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer getOneCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer updateCustomer(Customer customter)
        {
            throw new NotImplementedException();
        }
    }
}
