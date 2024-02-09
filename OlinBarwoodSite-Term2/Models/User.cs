using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlinBarwoodSite_Term2.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        [NotMapped]
        public IList<string>? RoleNames { get; set; }

    }
}
