using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRolesApi
    {
        [Get("/api/roles/{roleId}")]
        Task<Role> GetAsync(string roleId);
        
        [Get("/api/roles/byName/{roleName}")]
        Task<Role> GetByNameAsync(string roleName);
        
        [Get("/api/roles")]
        Task<List<Role>> GetAllAsync();
        
        [Get("/api/roles/byRoles")]
        Task<List<Role>> FindByIdsAsync([Query(CollectionFormat.Multi)]List<string> roleIds);
        
        [Get("/api/roles/byNames")]
        Task<List<Role>> FindByNamesAsync([Query(CollectionFormat.Multi)]List<string> roleNames);
        
        [Post("/api/roles")]
        Task SaveAsync([Body]Role entity);
        
        [Delete("/api/roles/{roleId}")]
        Task RemoveAsync(string roleId);
    }
}