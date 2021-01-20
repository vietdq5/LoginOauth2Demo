using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LoginOauth2Demo.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
