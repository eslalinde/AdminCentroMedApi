using Volo.Abp.Application.Dtos;

namespace AdminCentroMed
{
    public class FilterResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}