using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IConnectionUrlHistoryApi
    {
        [Get("/api/connection_url_history")]
        Task<Tuple<List<ConnectionUrlHistoricEvent>, int>> GetPageAsync([Query] int pageNum, [Query] int pageSize);
        
        [Get("/api/connection_url_history/{repositoryId}")]
        Task<List<ConnectionUrlHistoricEvent>> GetByRepositoryIdAsync(string repositoryId);
        
        [Post("/api/connection_url_history/{repositoryId}")]
        Task SaveConnectionUrlHistoryAsync(
            string repositoryId,
            [Query] string ip,
            [Query] string userAgent);
    }
}