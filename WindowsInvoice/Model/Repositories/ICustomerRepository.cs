using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Repositories
{
    public interface ICustomerRepository
    {
        //Insert
        Customer AddCustomer(Customer customer);
        
        //Read All
        IEnumerable<Customer> getAllCustomers();

        //Read One
        Customer getOneCustomer(int id);

        //Delete Customer
        void DeleteCustomer(int id);

        //Update Customer
        Customer updateCustomer(Customer customter);
    }
}
