using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class Address
{
    public int AddressId { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public bool? IsDefault { get; set; }

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
