﻿using System;
using System.Collections.Generic;

namespace WbDoAn.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ShortDesc { get; set; }

    public string? Description { get; set; }

    public int? CatId { get; set; }

    public int? Price { get; set; }

    public int? Discount { get; set; }

    public string? Image { get; set; }

    public string? Video { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public bool? BestSellers { get; set; }

    public bool? HomeFlag { get; set; }

    public bool? Active { get; set; }

    public string? Tags { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public string? MetaDesc { get; set; }

    public string? MetaKey { get; set; }

    public int? UnitslnStock { get; set; }

    public string? Creator { get; set; }

    public string? UpdateBy { get; set; }

    public virtual ICollection<AttributePrice> AttributePrices { get; } = new List<AttributePrice>();

    public virtual Category? Cat { get; set; }
}
