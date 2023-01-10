using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewQuotationTracker
{
    public int Jid { get; set; }

    public DateTime? EstfileReceivedDate { get; set; }

    public int? ClientId { get; set; }

    public int DepartmentId { get; set; }
}
