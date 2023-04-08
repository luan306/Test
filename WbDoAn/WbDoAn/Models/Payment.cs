using System;
using System.Collections.Generic;

namespace WbDoAn.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string? PaymentName { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
