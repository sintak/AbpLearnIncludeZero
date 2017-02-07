using System.Threading.Tasks;
using Abp.Application.Services;
using AbpLearnIncludeZero.Sessions.Dto;

namespace AbpLearnIncludeZero.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
