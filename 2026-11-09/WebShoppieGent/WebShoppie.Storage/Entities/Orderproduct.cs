using System;
using System.Collections.Generic;

namespace WebShoppie.Storage.Entities;

public partial class Orderproduct
{
    public int Orderproductid { get; set; }

    public int Orderid { get; set; }

    public int Productid { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
