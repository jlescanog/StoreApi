using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class Person
{
    public int PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? Dni { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
