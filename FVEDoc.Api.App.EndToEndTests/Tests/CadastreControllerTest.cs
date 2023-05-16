using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.CadastreData;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class CadastreControllerTest : TestBase<CadastreDataModel, CadastreDataModel>
{
    public CadastreControllerTest()
        : base("cadastre", BogusSeeder.SeedCadastreDataModel())
    {
    }
}

