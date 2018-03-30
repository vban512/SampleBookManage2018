using AbpMpaMvcEfInit.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AbpMpaMvcEfInit.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AbpMpaMvcEfInitDbContext _context;

        public InitialHostDbBuilder(AbpMpaMvcEfInitDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
