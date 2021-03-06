﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OmahaMtg.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User : IdentityUser<Guid, UserLogin, UserRole, UserClaim >
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, Guid> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WebsiteUrl { get; set; }
        public string TwitterUser { get; set; }
        public string GitHubUser { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual IList<Group> Groups { get; set; }
        public virtual IList<Rsvp> Rsvps { get; set; }
    }
}
