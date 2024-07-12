using System;
using System.Collections.Generic;

namespace PROG7311_POE_PART_2.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DateProd { get; set; }

    public int? ProductTypeId { get; set; }

    public int? UserId { get; set; }

    public virtual ProductType? ProductType { get; set; }

    public virtual User? User { get; set; }
}
