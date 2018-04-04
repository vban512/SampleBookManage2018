using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Customers.Dtos
{
   public class UpdateCustomerInput
    {
        [Range(1,Int32.MaxValue)]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public CustomerState? State { get; set; }
        [Required]
        public string Namesimple { get; set; }
        [Required]
        public string Bh { get; set; }
    }
}
