using System;
using System.Text.Json;
using Autofac;

namespace SettingX.Repositories.Common.Client
{
    public static class AutofacExtensions
    {
        public static void RegisterRepositoriesClient(
            this ContainerBuilder builder,
            string serviceUrl,
            JsonSerializerOptions jsonSerializerOptions)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            if (string.IsNullOrWhiteSpace(serviceUrl))
                throw new ArgumentException("Value cannot be null or whitespace.",
                    nameof(serviceUrl));

            builder.RegisterInstance(new Client(serviceUrl, jsonSerializerOptions))
                .As<IClient>()
                .SingleInstance();
        }
    }
}