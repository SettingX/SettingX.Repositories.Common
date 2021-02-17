using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRepositoryDataApi
    {
        [Get("/api/blobdata")]
        Task<HttpContent> GetDataAsync([Query] string file = null);
        
        [Put("/api/blobdata")]
        Task UpdateAsync([Query] string json, [Query] string userName, [Query] string ipAddress, [Query] string file = null);
        
        [Get("/api/blobdata/existing")]
        Task<List<string>> GetExistingFileNamesAsync();
        
        [Get("/api/blobdata/exists")]
        Task<bool> ExistsAsync([Query] string file = null);
        
        [Delete("/api/blobdata")]
        Task DeleteAsync([Query] string file);
    }
}