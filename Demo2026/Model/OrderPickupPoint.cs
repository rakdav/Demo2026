using System;
using System.Collections.Generic;

namespace Demo2026.Model;

public partial class OrderPickupPoint
{
    public int Id { get; set; }

    public string Zip { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string? Number { get; set; }

    public virtual ICollection<Pickup> Pickups { get; set; } = new List<Pickup>();
}
