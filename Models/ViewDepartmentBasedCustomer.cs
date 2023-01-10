using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewDepartmentBasedCustomer
{
    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string CustomerJobType { get; set; } = null!;

    public bool IsBlacklisted { get; set; }

    public string? BlacklistedReasons { get; set; }

    public bool IsDeleted { get; set; }

    public int Id { get; set; }

    public int DepartmentId { get; set; }
}
