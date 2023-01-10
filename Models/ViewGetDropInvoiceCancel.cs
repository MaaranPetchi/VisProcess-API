using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewGetDropInvoiceCancel
{
    public int Id { get; set; }

    public string? InvoiceNo { get; set; }

    public string ShortName { get; set; } = null!;
}
