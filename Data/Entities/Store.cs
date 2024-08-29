using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class Store
{
    public string StoreId { get; set; } = null!;

    public string? Name { get; set; }

    public int? AddressId { get; set; }

    public int? SalesPersonalId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual SalesPersonal? SalesPersonal { get; set; }

    public virtual ICollection<SalesPersonal> SalesPersonals { get; set; } = new List<SalesPersonal>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
