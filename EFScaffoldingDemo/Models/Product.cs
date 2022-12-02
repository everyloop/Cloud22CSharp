using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EFScaffoldingDemo.Models;

[DebuggerDisplay("{ProductName}, CategoryId={CategoryId} {(Category is null ? \"-\" : Category.CategoryName)}")]
public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public string? QuantityPerUnit { get; set; }

    public double? UnitPrice { get; set; }

    public int? UnitsInStock { get; set; }

    public int? UnitsOnOrder { get; set; }

    public int? ReorderLevel { get; set; }

    public int? Discontinued { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual Supplier? Supplier { get; set; }
}
