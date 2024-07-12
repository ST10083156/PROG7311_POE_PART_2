using System;
using System.Collections.Generic;

namespace PROG7311_POE_PART_2.Models;

public partial class ProductType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
