using mdbill.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace mdbill.DAL
{
    public class MdbillContext : DbContext 
    {
        public MdbillContext() : base("MdbillContext")
        {
        }

        public DbSet<Information > Informations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}