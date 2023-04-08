﻿using System;
using System.Collections.Generic;

namespace WbDoAn.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? Descriptiton { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
