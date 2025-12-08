using System;
using System.Collections.Generic;

namespace Demo2026.Model;

public partial class Order
{
    public string Articul { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string UnitMeasure { get; set; } = null!;

    public decimal Price { get; set; }

    public string Suplier { get; set; } = null!;

    public string Manufacture { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int Discount { get; set; }

    public int Count { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }

    public virtual ICollection<PickerItem> PickerItems { get; set; } = new List<PickerItem>();
}
