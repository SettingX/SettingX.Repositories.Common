using System.Text.Json;
using Refit;
using SettingX.Repositories.Common.Client.Api;

namespace SettingX.Repositories.Common.Client
{
    public class Client : IClient
    {
        public IRepositoryDataApi RepositoryDataApi { get; }
        public IAccountTokenHistoryApi AccountTokenHistoryApi { get; }
        public IConnectionUrlHistoryApi ConnectionUrlHistoryApi { get; }
        public IKeyValuesApi KeyValuesApi { get; }
        public IKeyValuesHistoryApi KeyValuesHistoryApi { get; }
        public ILocksApi LocksApi { get; }
        public INetworksApi NetworksApi { get; }
        public IRepositoriesApi RepositoriesApi { get; }
        public IRepositoriesUpdateHistoryApi RepositoriesUpdateHistoryApi { get; }
        public IRolesApi RolesApi { get; }
        public ISecretKeyValuesApi SecretKeyValuesApi { get; }
        public IServiceTokenHistoryApi ServiceTokenHistoryApi { get; }
        public IServiceTokensApi ServiceTokensApi { get; }
        public ITokensApi TokensApi { get; }
        public IUserActionsHistoryApi UserActionsHistoryApi { get; }
        public IUsersApi UsersApi { get; }
        public IUserSignInHistoryApi UserSignInHistoryApi { get; }
        
        public Client(string rootUrl, JsonSerializerOptions jsonSerializerOptions)
        {
            var settings = new RefitSettings(new SystemTextJsonContentSerializer(jsonSerializerOptions));
            RepositoryDataApi = RestService.For<IRepositoryDataApi>(rootUrl, settings);
            AccountTokenHistoryApi = RestService.For<IAccountTokenHistoryApi>(rootUrl, settings);
            ConnectionUrlHistoryApi = RestService.For<IConnectionUrlHistoryApi>(rootUrl, settings);
            KeyValuesApi = RestService.For<IKeyValuesApi>(rootUrl, settings);
            KeyValuesHistoryApi = RestService.For<IKeyValuesHistoryApi>(rootUrl, settings);
            LocksApi = RestService.For<ILocksApi>(rootUrl, settings);
            NetworksApi = RestService.For<INetworksApi>(rootUrl, settings);
            RepositoriesApi = RestService.For<IRepositoriesApi>(rootUrl, settings);
            RepositoriesUpdateHistoryApi = RestService.For<IRepositoriesUpdateHistoryApi>(rootUrl, settings);
            RolesApi = RestService.For<IRolesApi>(rootUrl, settings);
            SecretKeyValuesApi = RestService.For<ISecretKeyValuesApi>(rootUrl, settings);
            ServiceTokenHistoryApi = RestService.For<IServiceTokenHistoryApi>(rootUrl, settings);
            ServiceTokensApi = RestService.For<IServiceTokensApi>(rootUrl, settings);
            TokensApi = RestService.For<ITokensApi>(rootUrl, settings);
            UserActionsHistoryApi = RestService.For<IUserActionsHistoryApi>(rootUrl, settings);
            UsersApi = RestService.For<IUsersApi>(rootUrl, settings);
            UserSignInHistoryApi = RestService.For<IUserSignInHistoryApi>(rootUrl, settings);
        }
    }
}