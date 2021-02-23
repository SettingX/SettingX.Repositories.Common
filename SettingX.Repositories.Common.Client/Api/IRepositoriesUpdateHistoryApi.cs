using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IRepositoriesUpdateHistoryApi
    {
        [Get("/api/repositories_update_history/{initialCommit}")]
        Task<RepositoryUpdateHistoricEvent> GetAsync(string initialCommit);
        
        [Post("/api/repositories_update_history")]
        Task SaveRepositoryUpdateHistory([Body] RepositoryUpdateHistoricEvent entity);
        
        [Get("/api/repositories_update_history/list/{initialCommit}")]
        Task<List<RepositoryUpdateHistoricEvent>> GetAsyncByInitialCommit(string initialCommit);
        
        [Delete("/api/repositories_update_history")]
        Task RemoveRepositoryUpdateHistoryAsync([Query(CollectionFormat.Multi)] List<string> repositoryUpdateHistoryIds);
    }
}