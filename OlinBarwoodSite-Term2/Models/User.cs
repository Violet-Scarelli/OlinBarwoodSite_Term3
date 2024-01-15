using Microsoft.AspNetCore.Identity;

namespace OlinBarwoodSite_Term2.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        public string? Password { get; set; }

    }
}
