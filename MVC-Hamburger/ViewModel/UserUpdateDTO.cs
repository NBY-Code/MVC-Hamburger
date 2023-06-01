using System.ComponentModel.DataAnnotations;

namespace MVC_Hamburger.ViewModel
{
    public class UserUpdateDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        [MinLength(3)]
        public string Password { get; set; }
        [EmailAddress]
        public string EMail { get; set; }

    }
}
