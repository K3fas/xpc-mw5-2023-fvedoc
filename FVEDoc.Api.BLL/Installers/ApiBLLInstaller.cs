using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Installers;
using Microsoft.Extensions.DependencyInjection;

namespace FVEDoc.Api.BLL.Installers;
public class ApiBLLInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection)
    {
        serviceCollection.Scan(sel =>
            sel.FromAssemblyOf<ApiBLLInstaller>()
                .AddClasses(c => c.AssignableTo<IApiFacade>())
                .AsMatchingInterface()
                .WithScopedLifetime());
    }
}

