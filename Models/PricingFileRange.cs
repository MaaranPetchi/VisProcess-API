using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class PricingFileRange
{
    public int Id { get; set; }

    public int PricingId { get; set; }

    public int FromRange { get; set; }

    public int ToRange { get; set; }

    public decimal? ThousandStitchCharge { get; set; }

    public virtual Pricing Pricing { get; set; } = null!;
}
