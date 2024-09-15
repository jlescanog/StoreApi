using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class Promotion
{
    public int PromotionId { get; set; }

    public int? ProductId { get; set; }

    public decimal? Discount { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool? Status { get; set; }

    public virtual Product? Product { get; set; }
}
