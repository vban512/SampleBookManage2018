using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace AbpMpaMvcEfInit.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [MaxLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
