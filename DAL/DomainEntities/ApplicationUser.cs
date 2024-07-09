using Microsoft.AspNetCore.Identity;

namespace DAL.DomainEntities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
