using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Api.DAL.Mock.Repositories;
using FVEDoc.Common.Installers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Mock.Installers;
public class DALMockInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection)
    {
        // Scrutor
        serviceCollection.Scan(selector =>
                selector.FromAssemblyOf<DALMockInstaller>()
                        .AddClasses(classes => classes.AssignableTo(typeof(IApiRepository<>)))
                            .AsMatchingInterface()
                            .WithTransientLifetime()
                        .AddClasses(classes => classes.AssignableTo<BogusSeeder>())
                            .AsSelf()
                            .WithSingletonLifetime()
        );

    }
}

