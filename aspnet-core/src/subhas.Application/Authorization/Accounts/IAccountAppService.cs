using System.Threading.Tasks;
using Abp.Application.Services;
using subhas.Authorization.Accounts.Dto;

namespace subhas.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
