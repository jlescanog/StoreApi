using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class ShoppingCart
{
    public int CartItemId { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
