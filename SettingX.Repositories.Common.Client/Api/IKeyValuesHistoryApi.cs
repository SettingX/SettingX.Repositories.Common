using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IKeyValuesHistoryApi
    {
        [Post("/api/key_values_history/{keyValueId}")]
        Task SaveKeyValueHistoryAsync(
            string keyValueId,
            [Query] string newValue,
            [Query] string keyValues,
            [Query] string userName,
            [Query] string userIpAddress);

        [Post("/api/key_values_history/multiple")]
        Task SaveKeyValuesHistoryAsync(
            [Body] List<KeyValue> keyValues,
            [Query] string userName,
            [Query] string userIpAddress);

        [Post("/api/key_values_history/override/{keyValueId}")]
        Task SaveKeyValueOverrideHistoryAsync(
            string keyValueId,
            [Query] string newOverride,
            [Query] string keyValues,
            [Query] string userName,
            [Query] string userIpAddress);

        [Delete("/api/key_values_history/{keyValueId}")]
        Task DeleteKeyValueHistoryAsync(
            string keyValueId,
            [Query] string description,
            [Query] string userName,
            [Query] string userIpAddress);

        [Get("/api/key_values_history/{keyValueId}")]
        Task<List<KeyValueHistoricEvent>> GetHistoryByKeyValueAsync(string keyValueId);
    }
}