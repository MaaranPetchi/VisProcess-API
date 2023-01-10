using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewBusinessDay
{
    public string Name { get; set; } = null!;

    public string? ShortName { get; set; }

    public int Id { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public int? NumberOfDays { get; set; }

    public int? WithHolidays { get; set; }

    public string Description { get; set; } = null!;
}
