

using Microsoft.AspNetCore.Identity;

namespace Leave_Management_Portal.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
