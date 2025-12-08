using System;
using System.Collections.Generic;

namespace Demo2026.Model;

public partial class User
{
    public string Login { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Pickup> Pickups { get; set; } = new List<Pickup>();
}
