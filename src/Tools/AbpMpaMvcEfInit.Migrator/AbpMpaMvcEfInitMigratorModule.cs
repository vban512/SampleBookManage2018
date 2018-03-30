using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AbpMpaMvcEfInit.EntityFramework;

namespace AbpMpaMvcEfInit.Migrator
{
    [DependsOn(typeof(AbpMpaMvcEfInitDataModule))]
    public class AbpMpaMvcEfInitMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpMpaMvcEfInitDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}