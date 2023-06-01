using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Hamburger.Models
{
    public partial class OrdersMenu
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public string? Photo { get; set; }
        [NotMapped]
        public IFormFile? PhotoData { get; set; }
        public virtual Menu Menu { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
