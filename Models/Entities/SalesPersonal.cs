using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class SalesPersonal
{
    public int SalesPersonalId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? StoreId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Store? Store { get; set; }

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
