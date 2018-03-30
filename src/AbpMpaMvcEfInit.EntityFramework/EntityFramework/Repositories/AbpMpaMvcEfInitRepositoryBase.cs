using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpMpaMvcEfInit.EntityFramework.Repositories
{
    public abstract class AbpMpaMvcEfInitRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpMpaMvcEfInitDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpMpaMvcEfInitRepositoryBase(IDbContextProvider<AbpMpaMvcEfInitDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpMpaMvcEfInitRepositoryBase<TEntity> : AbpMpaMvcEfInitRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpMpaMvcEfInitRepositoryBase(IDbContextProvider<AbpMpaMvcEfInitDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
