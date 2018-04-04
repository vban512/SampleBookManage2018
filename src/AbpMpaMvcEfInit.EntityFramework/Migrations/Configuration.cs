using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using AbpMpaMvcEfInit.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace AbpMpaMvcEfInit.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<AbpMpaMvcEfInit.EntityFramework.AbpMpaMvcEfInitDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AbpMpaMvcEfInit";
        }

        protected override void Seed(AbpMpaMvcEfInit.EntityFramework.AbpMpaMvcEfInitDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
                new DefaultTestDataForCustomer(context).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
