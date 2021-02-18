using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface ITokensApi
    {
        [Get(("/api/tokens/{tokenId}"))]
        Task<Token> GetAsync(string tokenId);
        
        [Get(("/api/tokens/top"))]
        Task<Token> GetTopRecordAsync();
        
        [Get(("/api/tokens"))]
        Task<List<Token>> GetAllAsync();

        [Delete(("/api/tokens/{tokenId}"))]
        Task RemoveTokenAsync(string tokenId);
        
        [Post(("/api/tokens"))]
        Task SaveTokenAsync([Body] Token token);
    }
}