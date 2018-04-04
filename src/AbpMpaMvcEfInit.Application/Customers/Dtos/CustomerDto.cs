using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Customers.Dtos
{
  public class CustomerDto:EntityDto
    {
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Bh { get; set; }
        public string Namesimple { get; set; }
        public DateTime CreationTime { get; set; }
        public CustomerState State { get; set; }
    }

}
