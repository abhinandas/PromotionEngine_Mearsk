using Microsoft.Extensions.DependencyInjection;
using System;

namespace PromotionEngine_Mearsk
{
    public static class DependencyResolver
    {
        private static object _syncObject = new object();

        private static IServiceProvider _serviceProvider;
        private static ServiceCollection ServiceRegistryCollections { get; set; } = new ServiceCollection();

        public static IServiceProvider InitializeDependencies
        {

            get
            {
                lock (_syncObject)
                {
                    if (_serviceProvider != null)
                        return _serviceProvider;

                    ServiceRegistryCollections.AddSingleton<IProductServices, ProductService>();

                    _serviceProvider = ServiceRegistryCollections.BuildServiceProvider();

                    return _serviceProvider;
                }
            }
        }
    }
}
