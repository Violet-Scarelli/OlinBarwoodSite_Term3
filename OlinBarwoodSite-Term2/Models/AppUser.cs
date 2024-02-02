using Microsoft.AspNetCore.Identity;

namespace OlinBarwoodSite_Term2.Models
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Password { get; set; }

    }
}
