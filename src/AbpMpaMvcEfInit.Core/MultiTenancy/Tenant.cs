using Abp.MultiTenancy;
using AbpMpaMvcEfInit.Authorization.Users;

namespace AbpMpaMvcEfInit.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}