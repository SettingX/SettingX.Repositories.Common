using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRepositoriesUpdateHistoryApi
    {
        [Get("/api/repositories_update_history/{repositoryUpdateHistoryId}")]
        Task<RepositoryUpdateHistoricEvent> GetAsync(string repositoryUpdateHistoryId);
        
        [Post("/api/repositories_update_history")]
        Task SaveRepositoryUpdateHistory([Body] RepositoryUpdateHistoricEvent entity);
        
        [Get("/api/repositories_update_history/list/{initialCommit}")]
        Task<List<RepositoryUpdateHistoricEvent>> GetByInitialCommitAsync(string initialCommit);
        
        [Delete("/api/repositories_update_history")]
        Task RemoveRepositoryUpdateHistoryAsync([Query(CollectionFormat.Multi)] List<string> repositoryUpdateHistoryIds);
    }
}