﻿using System;
using System.Collections.Generic;

namespace WbDoAn.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? OrderNumber { get; set; }

    public int? Quantity { get; set; }

    public int? Discount { get; set; }

    public int? Price { get; set; }

    public DateTime? ShipDate { get; set; }

    public virtual Order? Order { get; set; }
}
