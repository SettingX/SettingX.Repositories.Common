using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IUserActionsHistoryApi
    {
        [Post("/api/user_action_history")]
        Task SaveUserActionHistoryAsync([Body] UserActionHistory userActionHistory);
    }
}