using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IAccountTokenHistoryApi
    {
        [Post("/api/account_token_history")]
        Task SaveTokenHistoryAsync([Body] Token token, [Query] string userName, [Query] string userIpAddress);
    }
}