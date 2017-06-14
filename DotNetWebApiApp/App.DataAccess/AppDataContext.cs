using App.DomainModels;
using System.Data.Entity;

namespace App.DataAccess
{
    public partial class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("name=AppDB")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetail>()
                .HasOptional(e => e.Address)
                .WithRequired(e => e.UserDetail);
                
        }
    }
}
