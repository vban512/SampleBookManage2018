using Abp.EntityFramework;
using AbpMpaMvcEfInit.Customers;
using AbpMpaMvcEfInit.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.EntityFramework.Repositories
{
   public class CustomerRepository:AbpMpaMvcEfInitRepositoryBase<Customer>,ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<AbpMpaMvcEfInitDbContext> dbContextProvider):base(dbContextProvider)
        {

        }
    }
}
