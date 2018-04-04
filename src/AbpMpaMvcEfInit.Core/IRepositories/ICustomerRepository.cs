using Abp.Domain.Repositories;
using AbpMpaMvcEfInit.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.IRepositories
{
  public interface ICustomerRepository:IRepository<Customer>
    {
    }
}
