using AdminCentroMed.Locations.Dtos;
using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace AdminCentroMed.Locations;

public class CountryAppServiceTests : AdminCentroMedApplicationTestBase
{
    private readonly ICountryAppService _countryAppService;

    public CountryAppServiceTests()
    {
        _countryAppService = GetRequiredService<ICountryAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Countries()
    {
        //Act
        var result = await _countryAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "Colombia");
    }

    [Fact]
    public async Task Should_Create_A_Valid_Country()
    {
        //Act
        var result = await _countryAppService.CreateAsync(
            new CreateUpdateCountryDto
            {
                Name = "Colombia",
                Code = "CO",
                NormalizeName = "COLOMBIA"
            }
        );

        //Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("Colombia");
    }

    [Fact]
    public async Task Should_Not_Create_A_Country_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _countryAppService.CreateAsync(
                 new CreateUpdateCountryDto
                 {
                     Name = "",
                     Code = "CO",
                     NormalizeName = "COLOMBIA"
                 }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    }
}