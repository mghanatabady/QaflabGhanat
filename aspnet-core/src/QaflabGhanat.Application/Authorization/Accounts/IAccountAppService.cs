using System.Threading.Tasks;
using Abp.Application.Services;
using QaflabGhanat.Authorization.Accounts.Dto;

namespace QaflabGhanat.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
