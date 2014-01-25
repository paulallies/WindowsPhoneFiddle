using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Model.Entities;
using Model.Repositories;

namespace WebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        readonly ICustomerRepository repo;

        public CustomerController() { 
            this.repo = new CustomerRepository();
        }

        public CustomerController(ICustomerRepository repo) {
            this.repo = repo;
        }

        // GET api/Customer
        public IEnumerable<Customer> GetCustomers()
        {
            return repo.getAllCustomers();
        }

        // GET api/Customer/5
        public Customer GetCustomer(int id)
        {
            Customer customer = repo.getOneCustomer(id);
            if (customer == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return customer;
        }

        // PUT api/Customer/5
        public HttpResponseMessage PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != customer.id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
          
          
            
            try
            {
                repo.updateCustomer(customer);
               
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Customer
        public HttpResponseMessage PostCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                repo.AddCustomer(customer);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, customer);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = customer.id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Customer/5
        public HttpResponseMessage DeleteCustomer(int id)
        {
            Customer customer = repo.getOneCustomer(id);
            if (customer == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }


            try
            {
                repo.deleteCustomer(customer);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}