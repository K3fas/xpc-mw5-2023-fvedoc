using Microsoft.Extensions.DependencyInjection;

namespace FVEDoc.Common.Installers;
public interface IInstaller
{
    void Install(IServiceCollection serviceCollection);
}

