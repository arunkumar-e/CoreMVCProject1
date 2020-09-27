﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Data;
using CoreMVCProject1.Models;

namespace CoreMVCProject1.Repository
{  
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _dbContext = null;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return _dbContext.Customers.SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }
    }
}