using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IUsersRepository
    {
        [Get("/api/users/byEmail")]
        Task<User> GetUserByUserEmailAsync([Query] string userEmail, [Query] string passwordHash);

        [Post("/api/users/admin")]
        Task CreateInitialAdminAsync([Query] string defaultUserEmail, [Query] string defaultUserPasswordHash);
        
        [Post("/api/users")]
        Task CreateUserAsync([Body] User user);
        
        [Put("/api/users")]
        Task<bool> UpdateUserAsync([Body] User user);
        
        [Get("/api/users")]
        Task<List<User>> GetUsersAsync();
        
        [Get("/api/users/top")]
        Task<User> GetTopUserRecordAsync();
        
        [Delete("/api/users")]
        Task<bool> RemoveUserAsync([Query] string userEmail);
    }
}