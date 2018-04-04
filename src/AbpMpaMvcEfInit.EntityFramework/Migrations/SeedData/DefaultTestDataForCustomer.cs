using AbpMpaMvcEfInit.Customers;
using AbpMpaMvcEfInit.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Migrations.SeedData
{
  public  class DefaultTestDataForCustomer
    {
        private readonly AbpMpaMvcEfInitDbContext _context;
        private static readonly List<Customer> _customers;
        public DefaultTestDataForCustomer(AbpMpaMvcEfInitDbContext context)
        {
            _context = context;
        }
        static DefaultTestDataForCustomer()
        {
            _customers = new List<Customer>()
            {
                new Customer("星源电子","23456779"),
                new Customer("友帮音响","34762288")
            };
        }

        public void Create()
        {
            foreach (var customer in _customers)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }  
                    
                
        }
    }
}
