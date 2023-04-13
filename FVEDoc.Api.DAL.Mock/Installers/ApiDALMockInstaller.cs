using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Installers;
using Microsoft.Extensions.DependencyInjection;

namespace FVEDoc.Api.DAL.Mock.Installers;
public class ApiDALMockInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection)
    {
        // Scrutor
        serviceCollection.Scan(selector =>
                selector.FromAssemblyOf<ApiDALMockInstaller>()
                        .AddClasses(classes => classes.AssignableTo(typeof(IApiRepository<>)))
                            .AsMatchingInterface()
                            .WithTransientLifetime()
                        .AddClasses(classes => classes.AssignableTo<BogusSeeder>())
                            .AsSelf()
                            .WithSingletonLifetime()
        );

    }
}

