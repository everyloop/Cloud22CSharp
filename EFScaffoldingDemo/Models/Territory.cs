using System;
using System.Collections.Generic;

namespace EFScaffoldingDemo.Models;

public partial class Territory
{
    public int Id { get; set; }

    public string? TerritoryDescription { get; set; }

    public int? RegionId { get; set; }

    public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; } = new List<EmployeeTerritory>();

    public virtual Region? Region { get; set; }
}
