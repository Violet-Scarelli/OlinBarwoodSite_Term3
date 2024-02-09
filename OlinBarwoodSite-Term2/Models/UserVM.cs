using Microsoft.AspNetCore.Identity;

namespace OlinBarwoodSite_Term2.Models
{
    public class UserVM
    {
        private IEnumerable<User> users = new List<User>();
        private IEnumerable<IdentityRole> roles = new List<IdentityRole>();

        public IEnumerable<User> Users { get => users; set => users = value; }
        public IEnumerable<IdentityRole> Roles { get => roles; set => roles = value; }
    }
}
