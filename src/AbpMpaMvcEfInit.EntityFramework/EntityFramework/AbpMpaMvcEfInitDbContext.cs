using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using AbpMpaMvcEfInit.Authorization.Roles;
using AbpMpaMvcEfInit.Authorization.Users;
using AbpMpaMvcEfInit.Customers;
using AbpMpaMvcEfInit.MultiTenancy;

namespace AbpMpaMvcEfInit.EntityFramework
{
    public class AbpMpaMvcEfInitDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Customer> Customers { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpMpaMvcEfInitDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpMpaMvcEfInitDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpMpaMvcEfInitDbContext since ABP automatically handles it.
         */
        public AbpMpaMvcEfInitDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AbpMpaMvcEfInitDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AbpMpaMvcEfInitDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
