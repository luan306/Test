using System;
using System.Collections.Generic;

namespace WbDoAn.Models;

public partial class LoaiTin
{
    public int LoaitinId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TblTinTuc> TblTinTucs { get; } = new List<TblTinTuc>();
}
