using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class Promotion
{
    public int PromotionId { get; set; }

    public int? ProductId { get; set; }

    public decimal? Discount { get; set; }

    public virtual Product? Product { get; set; }
}
