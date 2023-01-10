using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class EmployeeProcess
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int ProcessId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedUtc { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Process Process { get; set; } = null!;

    public virtual Employee? UpdatedByNavigation { get; set; }
}
