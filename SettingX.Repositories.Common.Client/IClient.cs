using SettingX.Repositories.Common.Client.Api;

namespace SettingX.Repositories.Common.Client
{
    public interface IClient
    {
        IRepositoryDataApi RepositoryDataApi { get; }
    }
}