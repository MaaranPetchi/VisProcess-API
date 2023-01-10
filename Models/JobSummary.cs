using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class JobSummary
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string MonthYear { get; set; } = null!;

    public int Pending { get; set; }

    public int? FreshCompleted { get; set; }

    public int? RevisionCompleted { get; set; }

    public int? ReworkCompleted { get; set; }

    public int TotalFiles { get; set; }

    public int? DeletedFiles { get; set; }
}
