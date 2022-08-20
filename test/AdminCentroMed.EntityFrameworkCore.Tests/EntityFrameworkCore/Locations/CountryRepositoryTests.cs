using System;
using System.Threading.Tasks;
using AdminCentroMed.Locations;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AdminCentroMed.EntityFrameworkCore.Locations;

public class CountryRepositoryTests : AdminCentroMedEntityFrameworkCoreTestBase
{
    private readonly ICountryRepository _countryRepository;

    public CountryRepositoryTests()
    {
        _countryRepository = GetRequiredService<ICountryRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
