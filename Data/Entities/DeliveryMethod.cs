using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class DeliveryMethod
{
    public int DeliveryMethodId { get; set; }

    public string? MethodName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
