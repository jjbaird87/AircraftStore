using System.Collections.Generic;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AircraftStore.WinForms.Account
{
    public class LoginUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public List<Role> Roles { get; set; } 

        public override string ToString()
        {
            return UserName;
        }
        public bool VerifyPassword(string password)
        {
            var usermanager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityContext()));
            var result = usermanager.PasswordHasher.VerifyHashedPassword(PasswordHash, password);
            return result == PasswordVerificationResult.Success;
        }

        public void AddToRole(string roleName)
        {            
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityContext()));            
            usermanager.AddToRole(Id, roleName);
        }

        public void RemoveFromRole(string role)
        {
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityContext()));
            usermanager.RemoveFromRole(Id, role);            
        }

        public void CreateUser()
        {
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityContext()));
            usermanager.Create(new ApplicationUser
            {
                Email = UserName,
                UserName = UserName,
                PasswordHash = PasswordHash
            });            
        }

    }

    public class Role
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
