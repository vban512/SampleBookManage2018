using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMpaMvcEfInit.Customers
{
  public class Customer:Entity,IHasCreationTime
    {
        public const int MaxNamesimpleLength = 32;
        public const int MaxBhLength = 16;
        [Required]
        [MaxLength(MaxNamesimpleLength)]
        public string Namesimple { get; set; }

        [Required]
        [MaxLength(MaxBhLength)]
        public string Bh { get; set; }

        public string Address { get; set; }
        public string Telephone { get; set; }
        public CustomerState State { get; set; }


        public DateTime CreationTime { get; set; }

        public Customer()
        {
            CreationTime = Clock.Now;
            State = CustomerState.Open;
        }

        public Customer(string namesimple,string bh)
        {
            Namesimple = namesimple;
            Bh = bh;
        }



    }
    public enum CustomerState : byte
    {
        Open = 0,
        Completed = 1
    }
}
