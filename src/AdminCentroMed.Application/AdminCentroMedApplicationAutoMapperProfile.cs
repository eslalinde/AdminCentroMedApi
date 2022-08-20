using AdminCentroMed.Locations;
using AdminCentroMed.Locations.Dtos;
using AutoMapper;

namespace AdminCentroMed;

public class AdminCentroMedApplicationAutoMapperProfile : Profile
{
    public AdminCentroMedApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Country, CountryDto>();
        CreateMap<CreateUpdateCountryDto, Country>(MemberList.Source);
    }
}
