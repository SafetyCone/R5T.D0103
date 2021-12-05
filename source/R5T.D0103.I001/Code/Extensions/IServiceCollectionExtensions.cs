using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0103.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OverridableProcessStartTimeProvider"/> implementation of <see cref="IProcessStartTimeProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOverridableProcessStartTimeProvider(this IServiceCollection services,
            IServiceAction<ICurrentProcessStartTimeProvider> currentProcessStartTimeProviderAction)
        {
            services
                .Run(currentProcessStartTimeProviderAction)
                .AddSingleton<IProcessStartTimeProvider, OverridableProcessStartTimeProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedProcessStartTimeProvider"/> implementation of <see cref="IProcessStartTimeProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedProcessStartTimeProvider(this IServiceCollection services,
            DateTime processStartTime)
        {
            services.AddSingleton<IProcessStartTimeProvider>(_ => new ConstructorBasedProcessStartTimeProvider(
                processStartTime));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedProcessStartTimeProvider"/> implementation of <see cref="IProcessStartTimeProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedProcessStartTimeProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProcessStartTimeProvider, StaticValuedProcessStartTimeProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CurrentProcessStartTimeProvider"/> implementation of <see cref="ICurrentProcessStartTimeProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCurrentProcessStartTimeProvider(this IServiceCollection services)
        {
            services.AddSingleton<ICurrentProcessStartTimeProvider, CurrentProcessStartTimeProvider>();

            return services;
        }
    }
}