using Abp.AutoMapper;
using AbpMpaMvcEfInit.Sessions.Dto;

namespace AbpMpaMvcEfInit.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}