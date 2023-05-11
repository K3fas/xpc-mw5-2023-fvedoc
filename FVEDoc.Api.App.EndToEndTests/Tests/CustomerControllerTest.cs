using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class CustomerControllerTest : TestBase<CustomerModel, CustomerModel>
{
    public CustomerControllerTest()
        :base("customer", BogusSeeder.SeedCustomerModel())
    {

    }
}

