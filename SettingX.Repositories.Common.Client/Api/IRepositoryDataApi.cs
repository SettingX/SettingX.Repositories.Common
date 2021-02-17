using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRepositoryDataApi
    {
        [Get("/api/repository_data")]
        Task<HttpContent> GetDataAsync([Query] string file = null);
        
        [Put("/api/repository_data")]
        Task UpdateAsync([Query] string json, [Query] string userName, [Query] string ipAddress, [Query] string file = null);
        
        [Get("/api/repository_data/existing")]
        Task<List<string>> GetExistingFileNamesAsync();
        
        [Get("/api/repository_data/exists")]
        Task<bool> ExistsAsync([Query] string file = null);
        
        [Delete("/api/repository_data")]
        Task DeleteAsync([Query] string file);
    }
}