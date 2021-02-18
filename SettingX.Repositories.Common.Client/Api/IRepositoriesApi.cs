using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRepositoriesApi
    {
        [Get("/api/repositories/{repositoryId}")]
        Task<Repository> GetAsync(string repositoryId);
        
        [Get("/api/repositories")]
        Task<List<Repository>> GetAllAsync();
        
        [Delete("/api/repositories/{repositoryId}")]
        Task RemoveRepositoryAsync(string repositoryId);
        
        [Post("/api/repositories")]
        Task SaveRepositoryAsync([Body] Repository repository);
    }
}