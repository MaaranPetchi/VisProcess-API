using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class KravsDesignation
{
    public int Id { get; set; }

    public int? DesignationId { get; set; }

    public string? Kradescription { get; set; }

    public bool? KraisDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedUtc { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public int? DepartmentId { get; set; }

    public int? ValueInPercentage { get; set; }
}
