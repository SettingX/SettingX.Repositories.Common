using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IServiceTokenHistoryApi
    {
        [Post("/api/service_token_history")]
        Task SaveTokenHistoryAsync([Body] ServiceToken token, [Query] string userName, [Query] string userIpAddress);
    }
}