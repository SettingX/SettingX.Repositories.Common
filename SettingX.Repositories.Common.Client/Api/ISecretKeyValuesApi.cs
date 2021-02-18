using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SettingX.Core.Models;

namespace SettingX.Repositories.Common.Client.Api
{
    public interface ISecretKeyValuesApi
    {
        [Get("/api/secret_key_value/dict")]
        Task<Dictionary<string, KeyValue>> GetAsync();
        
        [Get("/api/secret_key_value/top")]
        Task<KeyValue> GetTopRecordAsync();
        
        [Get("/api/secret_key_value/list")]
        Task<List<KeyValue>> GetAsync([Query] string id, [Query] string type);
        
        [Get("/api/secret_key_value/list/all")]
        Task<List<KeyValue>> GetKeyValuesAsync();
        
        [Get("/api/secret_key_value/ext")]
        Task<List<KeyValue>> GetKeyValuesAsync([Query] string keyRepoName, [Query] string filter, [Query] string search, [Query] string repositoryId = null);
        
        [Get("/api/secret_key_value/{key}")]
        Task<KeyValue> GetKeyValueAsync([Query] string key);
        
        [Get("/api/secret_key_value")]
        Task<Dictionary<string, KeyValue>> GetKeyValuesAsync([Query(CollectionFormat.Multi)] List<string> keys);

        [Put("/api/secret_key_value/update")]
        Task<bool> UpdateKeyValueAsync([Query(CollectionFormat.Multi)] List<KeyValue> keyValueList);
        
        [Put("/api/secret_key_value/replace")]
        Task<bool> ReplaceKeyValueAsync([Query(CollectionFormat.Multi)] List<KeyValue> keyValueList);
        
        [Delete("/api/secret_key_value/network_overrides/{networkId}")]
        Task RemoveNetworkOverridesAsync(string networkId);

        [Delete("/api/secret_key_value/{keyValueId}")]
        Task DeleteKeyValueWithHistoryAsync(
            string keyValueId,
            [Query] string description,
            [Query] string userName,
            [Query] string userIpAddress);
    }
}