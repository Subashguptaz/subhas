using System.Threading.Tasks;
using Abp.Application.Services;
using subhas.Sessions.Dto;

namespace subhas.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
