using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using AbpMpaMvcEfInit.EntityFramework;

namespace AbpMpaMvcEfInit
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AbpMpaMvcEfInitCoreModule))]
    public class AbpMpaMvcEfInitDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AbpMpaMvcEfInitDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
