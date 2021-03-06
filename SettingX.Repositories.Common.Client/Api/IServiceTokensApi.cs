using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IServiceTokensApi
    {
        [Get("/api/service_tokens")]
        Task<List<ServiceToken>> GetAllAsync();

        [Get("/api/service_tokens/{tokenKey}")]
        Task<ServiceToken> GetAsync(string tokenKey);
        
        [Post("/api/service_tokens")]
        Task<bool> SaveOrUpdateAsync([Body] ServiceToken token); //todo: remove return bool
        
        [Delete("/api/service_tokens/{tokenId}")]
        Task<bool> RemoveAsync(string tokenId); //todo: remove return bool
    }
}