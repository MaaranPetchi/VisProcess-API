using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class FileAttachment
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public byte[]? Fileattachment1 { get; set; }
}
