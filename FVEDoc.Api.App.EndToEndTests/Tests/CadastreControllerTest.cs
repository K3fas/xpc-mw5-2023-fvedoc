using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.CadastreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class CadastreControllerTest :TestBase<CadastreDataModel, CadastreDataModel>
{
    public CadastreControllerTest()
        :base("cadastre", BogusSeeder.SeedCadastreDataModel())
    {
    }
}

