using WebApplication1.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ConferenceApp.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser{
                UserName = "SuperAdmin",
                Email="superadmin@gmail.com",
                PasswordHash = hasher.HashPassword(null, "007Katrina#"),
            });
            base.OnModelCreating(builder);
        }

        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomConfiguration> RoomConfiguration { get; set; }
        public DbSet<RoomFeatures> RoomFeature { get; set; }
        public DbSet<RoomSettings> RoomSetting { get; set; }
        public DbSet<UserRoomMapping> UserRoomMapping { get; set; }
    }
}
