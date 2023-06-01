using Microsoft.AspNetCore.Identity;

namespace MVC_Hamburger.Models
{
    public class AppUser: IdentityUser
    {
        public AppUser()
        {
            Orders = new List<Order>();
        }
        public virtual ICollection<Order> Orders { get; set; }
     
      
    }
}
