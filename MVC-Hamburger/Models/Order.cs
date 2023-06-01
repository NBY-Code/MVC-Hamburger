using System;
using System.Collections.Generic;

namespace MVC_Hamburger.Models
{
    public partial class Order
    {
        public Order()
        {
            OrdersExtraMaterials = new HashSet<OrdersExtraMaterial>();
            OrdersMenus = new HashSet<OrdersMenu>();
        }

        public int Id { get; set; }
        public string? Size { get; set; }
        public int? Count { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public virtual ICollection<OrdersExtraMaterial> OrdersExtraMaterials { get; set; }
        public virtual ICollection<OrdersMenu> OrdersMenus { get; set; }
    }
}
