using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Installers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Installers;
public class ApiBLLInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection)
    {
        serviceCollection.Scan(sel =>
            sel.FromAssemblyOf<ApiBLLInstaller>()
                .AddClasses(c => c.AssignableTo<IAppFacade>())
                .AsMatchingInterface()
                .WithScopedLifetime());
    }
}

