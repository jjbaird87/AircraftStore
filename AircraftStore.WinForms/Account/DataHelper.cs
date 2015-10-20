using System.Collections.Generic;
using System.Linq;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Models;

namespace AircraftStore.WinForms.Account
{
    public static class DataHelper
    {
        static readonly IdentityContext IdDb = new IdentityContext();

        public static List<ApplicationUser> GetFullUsers()
        {
            return IdDb.Users.ToList();
        }

        public static List<LoginUser> GetLoginUsers()
        {
            var loginUsers = new List<LoginUser>();
            
            var roles = IdDb.Roles.ToList();
            var users = IdDb.Users.ToList();

            bool adminFound = false;

            foreach (var loginUser in users)
            {
       
                var user = new LoginUser
                {
                    Id = loginUser.Id,
                    PasswordHash = loginUser.PasswordHash,
                    UserName = loginUser.UserName,                   
                    Roles = new List<Role>()
                };                
                foreach (var role in loginUser.Roles.Select(identityUserRole => roles.Find(i => i.Id == identityUserRole.RoleId)))
                {
                    user.Roles.Add(new Role {Id = role.Id, Name = role.Name});
                }
                loginUsers.Add(user);

                if (loginUser.UserName == "admin@aircraftstore.com")
                {
                    adminFound = true;
                }
            }

            //If admin user does not yet exist create
            if (adminFound) return loginUsers;

            var adminUser = new LoginUser
            {
                UserName = "admin@aircraftstore.com",
                PasswordHash = "ALpMLxEVyd1jbBDAXGByZNfof8bJiLEU7G18oXyaKeoMg0f/xhLAAdUTBzSQ1NiFqQ=="
            };
            adminUser.CreateUser();
            var admin = IdDb.Users.First(i => i.UserName == "admin@aircraftstore.com");
            adminUser.Id = admin.Id;
            adminUser.AddToRole("Admin");
            adminUser.Roles = new List<Role> {new Role {Name = "Admin"}};
            loginUsers.Add(adminUser);

            return loginUsers;
        }

        public static List<Role> GetRoles()
        {
            var roles = IdDb.Roles.ToList();
            return roles.Select(role => new Role {Id = role.Id, Name = role.Name}).ToList();
        }
    }
}
