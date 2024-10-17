using Microsoft.AspNetCore.Identity;

namespace UserService.Models
{
    public class User : IdentityUser
    {
       
        public string Address {  get; set; } = string.Empty;
        public bool isActive {  get; set; }
    }
}
