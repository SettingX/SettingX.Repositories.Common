using System.Text.Json;
using Refit;
using SettingX.Repositories.Common.Client.Api;

namespace SettingX.Repositories.Common.Client
{
    public class Client : IClient
    {
        public IRepositoryDataApi RepositoryDataApi { get; }
        
        public Client(string rootUrl, JsonSerializerOptions jsonSerializerOptions)
        {
            var settings = new RefitSettings(new SystemTextJsonContentSerializer(jsonSerializerOptions));
            RepositoryDataApi = RestService.For<IRepositoryDataApi>(rootUrl, settings);
        }
    }
}