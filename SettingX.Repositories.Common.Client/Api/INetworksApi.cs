using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface INetworksApi
    {
        [Get("/api/networks")]
        Task<List<Network>> GetAllAsync();
        
        [Get("/api/networks/{ip}")]
        Task<Network> GetByIpAsync(string ip);
        
        [Post("/api/networks")]
        Task AddAsync([Body] Network network);
        
        [Put("/api/networks")]
        Task UpdateAsync([Body] Network network);
        
        [Delete("/api/networks/{id}")]
        Task DeleteAsync(string id);
    }
}