using System;
using System.Collections.Generic;

namespace StoreApi.Data.Entities;

public partial class IngresoSalidum
{
    public int IngresoSalidaId { get; set; }

    public int? UserId { get; set; }

    public string? Type { get; set; }

    public DateOnly? DateInOut { get; set; }

    public TimeOnly? TimeInOut { get; set; }

    public virtual UserAccount? User { get; set; }
}
