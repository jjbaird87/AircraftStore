using AircraftStore.Dal.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AircraftStore.Dal.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext()
            : base("name=IdentityContext")
        {
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
