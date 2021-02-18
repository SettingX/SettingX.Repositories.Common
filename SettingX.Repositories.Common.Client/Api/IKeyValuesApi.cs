using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface IKeyValuesApi
    {
        [Get("/api/key_value/dict")]
        Task<Dictionary<string, KeyValue>> GetAsync();
        
        [Get("/api/key_value/top")]
        Task<KeyValue> GetTopRecordAsync();
        
        [Get("/api/key_value/list")]
        Task<List<KeyValue>> GetAsync([Query] string id, [Query] string type);
        
        [Get("/api/key_value/list/all")]
        Task<List<KeyValue>> GetKeyValuesAsync();
        
        [Get("/api/key_value/ext")]
        Task<List<KeyValue>> GetKeyValuesAsync([Query] string keyRepoName, [Query] string filter, [Query] string search, [Query] string repositoryId = null);
        
        [Get("/api/key_value/{key}")]
        Task<KeyValue> GetKeyValueAsync([Query] string key);
        
        [Get("/api/key_value")]
        Task<Dictionary<string, KeyValue>> GetKeyValuesAsync([Query(CollectionFormat.Multi)] List<string> keys);

        [Put("/api/key_value/update")]
        Task<bool> UpdateKeyValueAsync([Query(CollectionFormat.Multi)] List<KeyValue> keyValueList);
        
        [Put("/api/key_value/replace")]
        Task<bool> ReplaceKeyValueAsync([Query(CollectionFormat.Multi)] List<KeyValue> keyValueList);
        
        [Delete("/api/key_value/network_overrides/{networkId}")]
        Task RemoveNetworkOverridesAsync(string networkId);

        [Delete("/api/key_value/{keyValueId}")]
        Task DeleteKeyValueWithHistoryAsync(
            string keyValueId,
            [Query] string description,
            [Query] string userName,
            [Query] string userIpAddress);
    }
}