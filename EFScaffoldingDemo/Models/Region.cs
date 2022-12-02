using System;
using System.Collections.Generic;

namespace EFScaffoldingDemo.Models;

public partial class Region
{
    public int Id { get; set; }

    public string? RegionDescription { get; set; }

    public virtual ICollection<Territory> Territories { get; } = new List<Territory>();
}
