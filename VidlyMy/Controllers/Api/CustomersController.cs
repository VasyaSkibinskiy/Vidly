using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyMy.Dto;
using VidlyMy.Models;

namespace VidlyMy.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private CustomerContext _context;
        public CustomersController()
        {
            _context = new CustomerContext();
        }
        //get api/gustomerss
        public IEnumerable<CustomerDto> GetCustomer()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }
        //get customers/1
        public CustomerDto GetCustomer (int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Customer, CustomerDto>(customer);
        }

        //post api/customer
        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.Id = customer.Id;
            return customerDto;

        }

        // put api/customer
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);

            _context.SaveChanges();
        }

        //Delete api//customers
        [HttpDelete]
        public void DeleteCustomers(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

        }
    }
}
