using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using AbpLearnIncludeZero.Authorization.Roles;
using AbpLearnIncludeZero.Configuration;
using AbpLearnIncludeZero.MultiTenancy;
using AbpLearnIncludeZero.Users;
using AbpLearnIncludeZero.Web;

namespace AbpLearnIncludeZero.EntityFramework
{
    [DbConfigurationType(typeof(AbpLearnIncludeZeroDbConfiguration))]
    public class AbpLearnIncludeZeroDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public AbpLearnIncludeZeroDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                AbpLearnIncludeZeroConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of AbpLearnIncludeZeroDbContext since ABP automatically handles it.
         */
        public AbpLearnIncludeZeroDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public AbpLearnIncludeZeroDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public AbpLearnIncludeZeroDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class AbpLearnIncludeZeroDbConfiguration : DbConfiguration
    {
        public AbpLearnIncludeZeroDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
