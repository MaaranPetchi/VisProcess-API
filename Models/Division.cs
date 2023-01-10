using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class Division
{
    public int Id { get; set; }

    public string DivisionName { get; set; } = null!;

    public int TeamLeadEmpId { get; set; }

    public int Capacity { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreateUtc { get; set; }

    public bool? IsDeleted { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdateUtc { get; set; }

    public virtual ICollection<CustomerVsDivision> CustomerVsDivisions { get; } = new List<CustomerVsDivision>();
}
