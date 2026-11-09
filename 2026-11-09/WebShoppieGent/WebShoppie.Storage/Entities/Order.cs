using System;
using System.Collections.Generic;

namespace WebShoppie.Storage.Entities;

public partial class Order
{
    public int Orderid { get; set; }

    public DateTime Orderdate { get; set; }

    public int Customerid { get; set; }

    public decimal Totalprice { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Orderproduct> Orderproducts { get; set; } = new List<Orderproduct>();
}
