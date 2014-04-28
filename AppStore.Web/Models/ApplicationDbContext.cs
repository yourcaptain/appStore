using System.Data.Entity;

using AppStore.Data;

using Microsoft.AspNet.Identity.EntityFramework;

namespace AppStore.Web.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<MyUserInfo> MyUserInfo { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationVersion> ApplicationVersions { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}