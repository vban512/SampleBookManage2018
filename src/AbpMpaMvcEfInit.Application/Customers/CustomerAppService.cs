using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Timing;
using AbpMpaMvcEfInit.Customers.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Customers
{
   public class CustomerAppService:AbpMpaMvcEfInitAppServiceBase,ICustomerAppService
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerAppService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public GetCustomersOutput GetCustomers(GetCustomersInput input)
        {
            var query = _customerRepository.GetAll();
            /*
            if (input.State.HasFlag(1))
            {

            }
            */
            return new GetCustomersOutput
            {
                Customers=Mapper.Map<List<CustomerDto>>(query.ToList())
            };
        }
        public CustomerDto GetCustomerById(int customerId)
        {
            var customer = _customerRepository.Get(customerId);
            return customer.MapTo<CustomerDto>();
        }
        public void UpdateCustomer(UpdateCustomerInput input)
        {
            Logger.Info("Updating a Customer for input:" + input);
           // var customer = _customerRepository.Get(input.Id);
          // if (input.Telephone.Equals)
          //  customer.Sta=_customerRepository.Load()
        }
        public int CreateCustomer(CreateCustomerInput input)
        {
            Logger.Info("Creating a Customer for input:" + input);
            var customer = new Customer
            {
                Address=input.Address,
                Telephone=input.Telephone,
                State=input.State,
                CreationTime=Clock.Now,
                Bh=input.Bh,
                Namesimple=input.Namesimple
            };
            return _customerRepository.InsertAndGetId(customer);
        }
        public void DeleteCustomer(int customerId)
        {
            var customer = _customerRepository.Get(customerId);
            if (customer!=null)
            {
                _customerRepository.Delete(customer);
            }
        }
        /*
        public IList<CustomerDto> GetAllCustomers()
        {

        }
        */
    }
}
