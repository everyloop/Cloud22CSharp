using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EFScaffoldingDemo.Models;


[DebuggerDisplay("{CategoryName}")]
public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
