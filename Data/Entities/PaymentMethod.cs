using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public int? CustomerId { get; set; }

    public string? MethodName { get; set; }

    public virtual Customer? Customer { get; set; }
}
