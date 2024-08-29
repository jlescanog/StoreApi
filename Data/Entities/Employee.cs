using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? PersonId { get; set; }

    public string? StoreId { get; set; }

    public virtual Person? Person { get; set; }

    public virtual Store? Store { get; set; }

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}
