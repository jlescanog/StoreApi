using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? SalesPersonalId { get; set; }

    public string? StoreId { get; set; }

    public string? Comments { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? DeliveryMethodId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual DeliveryMethod? DeliveryMethod { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual SalesPersonal? SalesPersonal { get; set; }

    public virtual Store? Store { get; set; }
}
