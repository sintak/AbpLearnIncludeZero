using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpLearnIncludeZero.EntityFramework.Repositories
{
    public abstract class AbpLearnIncludeZeroRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpLearnIncludeZeroDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpLearnIncludeZeroRepositoryBase(IDbContextProvider<AbpLearnIncludeZeroDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpLearnIncludeZeroRepositoryBase<TEntity> : AbpLearnIncludeZeroRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpLearnIncludeZeroRepositoryBase(IDbContextProvider<AbpLearnIncludeZeroDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
