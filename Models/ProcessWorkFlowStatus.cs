using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ProcessWorkFlowStatus
{
    public int Id { get; set; }

    public int? JobId { get; set; }

    public int? DepartmentId { get; set; }

    public bool? IsStatus { get; set; }
}
