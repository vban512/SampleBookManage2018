using Abp.Application.Services;
using AbpMpaMvcEfInit.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Customers
{
  public interface ICustomerAppService:IApplicationService
    {
        GetCustomersOutput GetCustomers(GetCustomersInput input);
        void UpdateCustomer(UpdateCustomerInput input);
        int CreateCustomer(CreateCustomerInput input);
        CustomerDto GetCustomerById(int customerId);
        void DeleteCustomer(int customerId);
       // IList<CustomerDto> GetAllCustomers();
    }
}
