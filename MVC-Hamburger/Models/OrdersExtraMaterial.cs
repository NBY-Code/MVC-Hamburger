using System;
using System.Collections.Generic;

namespace MVC_Hamburger.Models
{
    public partial class OrdersExtraMaterial
    {
        public int OrderId { get; set; }
        public int ExtraMaterialId { get; set; }
        public int Quantity { get; set; }

        public virtual ExtraMaterial ExtraMaterial { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
