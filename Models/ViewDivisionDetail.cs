using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewDivisionDetail
{
    public int EmployeeId { get; set; }

    public string EmployeeCode { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;
}
