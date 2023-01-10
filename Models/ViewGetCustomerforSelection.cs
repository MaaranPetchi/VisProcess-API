using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewGetCustomerforSelection
{
    public int Id { get; set; }

    public string? ShortName { get; set; }

    public string Name { get; set; } = null!;
}
