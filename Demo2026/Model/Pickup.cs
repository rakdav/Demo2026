using System;
using System.Collections.Generic;

namespace Demo2026.Model;

public partial class Pickup
{
    public int Id { get; set; }

    public DateOnly DateOrder { get; set; }

    public DateOnly DateFinish { get; set; }

    public int Point { get; set; }

    public string Login { get; set; } = null!;

    public int Code { get; set; }

    public string Status { get; set; } = null!;

    public virtual User LoginNavigation { get; set; } = null!;

    public virtual ICollection<PickerItem> PickerItems { get; set; } = new List<PickerItem>();

    public virtual OrderPickupPoint PointNavigation { get; set; } = null!;
}
