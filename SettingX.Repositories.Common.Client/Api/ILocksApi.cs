using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface ILocksApi
    {
        [Get("/api/lock")]
        Task<EditLock> GetJsonPageLockAsync();
        
        [Post("/api/lock")]
        Task SetJsonPageLockAsync([Query] string userEmail, [Query] string userName, [Query] string ipAddress);
        
        [Put("/api/lock")]
        Task ResetJsonPageLockAsync();
    }
}