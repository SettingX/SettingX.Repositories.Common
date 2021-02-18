using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IUserSignInHistoryApi
    {
        [Post("/api/user_signin_history")]
        Task SaveUserLoginAsync([Body] User user, [Query]string userIpAddress);
    }
}