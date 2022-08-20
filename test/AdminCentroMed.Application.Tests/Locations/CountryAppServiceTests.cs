using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AdminCentroMed.Locations;

public class CountryAppServiceTests : AdminCentroMedApplicationTestBase
{
    private readonly ICountryAppService _countryAppService;

    public CountryAppServiceTests()
    {
        _countryAppService = GetRequiredService<ICountryAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

