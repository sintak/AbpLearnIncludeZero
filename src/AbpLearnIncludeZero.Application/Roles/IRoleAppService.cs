using System.Threading.Tasks;
using Abp.Application.Services;
using AbpLearnIncludeZero.Roles.Dto;

namespace AbpLearnIncludeZero.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
