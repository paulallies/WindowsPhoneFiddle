using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface ICustomerRepository
    {
        //Insert
        Customer AddCustomer(Customer customer);

        //Delete
        void deleteCustomer(Customer customer);

        //Update
        Customer updateCustomer(Customer customer);

        //Read All
        IEnumerable<Customer> getAllCustomers();

        //Read One
        Customer getOneCustomer(int id);

    }
}
