using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRolesRepository
    {
        [Get("/api/roles/{roleId}")]
        Task<Role> GetAsync(string roleId);
        
        [Get("/api/roles")]
        Task<List<Role>> GetAllAsync();
        
        [Get("/api/roles/byRoles")]
        Task<List<Role>> GetAllByRolesAsync([Query(CollectionFormat.Multi)]List<string> roles);
        
        [Get("/api/roles/forNewRole")]
        Task<List<Role>> GetAllForNewRoleAsync([Query] string existingRole, [Query] string name);
        
        [Post("/api/roles")]
        Task SaveAsync([Body]Role entity);
        
        [Delete("/api/roles/{roleId}")]
        Task RemoveAsync(string roleId);
    }
}