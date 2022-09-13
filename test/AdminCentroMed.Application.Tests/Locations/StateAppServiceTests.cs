using AdminCentroMed.Locations.Dtos;
using Shouldly;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace AdminCentroMed.Locations;

public class StateAppServiceTests : AdminCentroMedApplicationTestBase
{
    private readonly IStateAppService _stateAppService;

    public StateAppServiceTests()
    {
        _stateAppService = GetRequiredService<IStateAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_States()
    {
        //Act
        var result = await _stateAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "Antioquia");
    }

    [Fact]
    public async Task Should_Create_A_Valid_State()
    {
        //Act
        var result = await _stateAppService.CreateAsync(
            new CreateUpdateStateDto
            {
                Name = "Antioquia",
                NormalizeName = "ANTIOQUIA",
                CountryId = Guid.NewGuid()
            }
        );

        //Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("Antioquia");
    }

    [Fact]
    public async Task Should_Not_Create_A_State_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _stateAppService.CreateAsync(
                 new CreateUpdateStateDto
                 {
                     Name = "",
                     NormalizeName = "ANTIOQUIA",
                     CountryId = Guid.NewGuid()
                 }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    }
}