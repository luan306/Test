using System;
using System.Collections.Generic;

namespace WbDoAn.Models;

public partial class PdGroup
{
    public int PdGroupId { get; set; }

    public string? NamePdGroup { get; set; }

    public virtual ICollection<Category> Categories { get; } = new List<Category>();
}
