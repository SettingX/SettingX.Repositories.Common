using SettingX.Repositories.Common.Client.Api;

namespace SettingX.Repositories.Common.Client
{
    public interface IClient
    {
        IRepositoryDataApi RepositoryDataApi { get; }
        IAccountTokenHistoryApi AccountTokenHistoryApi { get; }
        IConnectionUrlHistoryApi ConnectionUrlHistoryApi { get; }
        IKeyValuesApi KeyValuesApi { get; }
        IKeyValuesHistoryApi KeyValuesHistoryApi { get; }
        ILocksApi LocksApi { get; }
        INetworksApi NetworksApi { get; }
        IRepositoriesApi RepositoriesApi { get; }
        IRepositoriesUpdateHistoryApi RepositoriesUpdateHistoryApi { get; }
        IRolesApi RolesApi { get; }
        ISecretKeyValuesApi SecretKeyValuesApi { get; }
        IServiceTokenHistoryApi ServiceTokenHistoryApi { get; }
        IServiceTokensApi ServiceTokensApi { get; }
        ITokensApi TokensApi { get; }
        IUserActionsHistoryApi UserActionsHistoryApi { get; }
        IUsersApi UsersApi { get; }
        IUserSignInHistoryApi UserSignInHistoryApi { get; }
    }
}