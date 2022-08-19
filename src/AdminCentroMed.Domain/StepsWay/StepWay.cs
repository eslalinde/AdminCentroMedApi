using System;
using Volo.Abp.Domain.Entities;

namespace AdminCentroMed.StepsWay;

public class StepWay : Entity<Guid>
{
    public string Name { get; set; }
    public string NormalizedName { get; set; }
    public int Order { get; set; }

    protected StepWay()
    {
    }

    public StepWay(
        Guid id,
        string name,
        string normalizedName,
        int order
    ) : base(id)
    {
        Name = name;
        NormalizedName = normalizedName;
        Order = order;
    }
}