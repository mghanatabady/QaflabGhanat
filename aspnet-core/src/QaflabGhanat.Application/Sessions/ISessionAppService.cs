using System.Threading.Tasks;
using Abp.Application.Services;
using QaflabGhanat.Sessions.Dto;

namespace QaflabGhanat.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
