﻿using System;
using System.Collections.Generic;

namespace Warehouse_Management_System.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? Category { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
