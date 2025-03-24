﻿using System;
using System.Collections.Generic;

namespace Warehouse_Management_System.Models;

public partial class Stock
{
    public int StockId { get; set; }

    public int ItemId { get; set; }

    public int SupplierId { get; set; }

    public int Quantity { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
