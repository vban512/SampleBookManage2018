using AbpMpaMvcEfInit.Customers.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Customers
{
   public class CustomerDtoMapping:IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            //定义单向映射
            mapperConfig.CreateMap<CreateCustomerInput, Customer>();
            mapperConfig.CreateMap<UpdateCustomerInput, Customer>();
            mapperConfig.CreateMap<CustomerDto, UpdateCustomerInput>();

            //自定义映射
           // var taskDtoMapper = mapperConfig.CreateMap<Task, TaskDto>();
           // taskDtoMapper.ForMember(dto => dto.AssignedPersonName, map => map.MapFrom(m => m.AssignedPerson.FullName));
        }
    }
}
