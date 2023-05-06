using FVEDoc.Common.Installers;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FVEDoc.Web.DAL.Installers;
public class WebDALInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection)
    {
        // Scrutor
        serviceCollection.Scan(selector =>
                selector.FromAssemblyOf<WebDALInstaller>()
                        .AddClasses(classes => classes.AssignableTo(typeof(IWebRepository)))
                            .AsMatchingInterface()
                            .WithTransientLifetime());
    }
}

