using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? StoreId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? AddressId { get; set; }

    public string? Dni { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public DateOnly? Birthdate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
