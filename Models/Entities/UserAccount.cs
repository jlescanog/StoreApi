using System;
using System.Collections.Generic;

namespace StoreApi.Models.Entities;

public partial class UserAccount
{
    public int UserId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Username { get; set; }

    public string? PasswordHash { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<IngresoSalidum> IngresoSalida { get; set; } = new List<IngresoSalidum>();
}
