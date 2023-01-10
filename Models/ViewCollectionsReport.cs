using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewCollectionsReport
{
    public string ShortName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CollectionDate { get; set; }

    public decimal CollectionAmount { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? AdjustmentAmount { get; set; }

    public DateTime? Est { get; set; }
}
