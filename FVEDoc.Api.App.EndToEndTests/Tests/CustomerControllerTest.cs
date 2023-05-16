using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Customer;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class CustomerControllerTest : TestBase<CustomerModel, CustomerModel>
{
    public CustomerControllerTest()
        : base("customer", BogusSeeder.SeedCustomerModel())
    {

    }
}

