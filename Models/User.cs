using System;
using System.Collections.Generic;

namespace PROG7311_POE_PART_2.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? RoleId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual Role? Role { get; set; }
}
