﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Installers;
public interface IInstaller
{
    void Install(IServiceCollection serviceCollection);
}

