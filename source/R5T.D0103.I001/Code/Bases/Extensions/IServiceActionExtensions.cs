using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0103.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OverridableProcessStartTimeProvider"/> implementation of <see cref="IProcessStartTimeProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessStartTimeProvider> AddOverridableProcessStartTimeProviderAction(this IServiceAction _,
            IServiceAction<ICurrentProcessStartTimeProvider> currentProcessStartTimeProviderAction)
        {
            var serviceAction = _.New<IProcessStartTimeProvider>(services => services.AddOverridableProcessStartTimeProvider(
                currentProcessStartTimeProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedProcessStartTimeProvider"/> implementation of <see cref="IProcessStartTimeProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessStartTimeProvider> AddStaticValuedProcessStartTimeProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IProcessStartTimeProvider>(services => services.AddStaticValuedProcessStartTimeProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedProcessStartTimeProvider"/> implementation of <see cref="IProcessStartTimeProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessStartTimeProvider> AddConstructorBasedProcessStartTimeProviderAction(this IServiceAction _,
            DateTime processStartTime)
        {
            var serviceAction = _.New<IProcessStartTimeProvider>(services => services.AddConstructorBasedProcessStartTimeProvider(
                processStartTime));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="CurrentProcessStartTimeProvider"/> implementation of <see cref="ICurrentProcessStartTimeProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ICurrentProcessStartTimeProvider> AddCurrentProcessStartTimeProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<ICurrentProcessStartTimeProvider>(services => services.AddCurrentProcessStartTimeProvider());
            return serviceAction;
        }
    }
}
