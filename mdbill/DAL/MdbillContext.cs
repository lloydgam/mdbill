using mdbill.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;

namespace mdbill.DAL
{
    public class MdbillContext : IdentityDbContext
    {
        public MdbillContext() : base("MdbillContext")
        {
        }

        public DbSet<Information > Informations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }

        public System.Data.Entity.DbSet<mdbill.Models.Provider> Providers { get; set; }

        public System.Data.Entity.DbSet<mdbill.Models.Contact> Contacts { get; set; }
    }
}