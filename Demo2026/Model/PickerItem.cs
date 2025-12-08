using System;
using System.Collections.Generic;

namespace Demo2026.Model;

public partial class PickerItem
{
    public int Id { get; set; }

    public int OrderNumber { get; set; }

    public string Articul { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual Order ArticulNavigation { get; set; } = null!;

    public virtual Pickup OrderNumberNavigation { get; set; } = null!;
}
