using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Hamburger.Models
{
    public partial class Menu
    {


        public Menu()
        {
            OrdersMenus = new HashSet<OrdersMenu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Photo { get; set; }
        [NotMapped]
        public IFormFile? PhotoData { get; set; }

        public virtual ICollection<OrdersMenu> OrdersMenus { get; set; }


    }
}
