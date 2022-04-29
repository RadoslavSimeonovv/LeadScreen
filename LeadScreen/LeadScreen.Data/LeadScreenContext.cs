namespace LeadScreen.Data
{
    using LeadScreen.Data.Configuration;
    using LeadScreen.Data.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Context and entity configurations
    /// </summary>
    public class LeadScreenContext : DbContext
    {
        public LeadScreenContext(DbContextOptions<LeadScreenContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Subarea> Subarea { get; set; }
        public virtual DbSet<Lead> Lead { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SubareaConfig());
            modelBuilder.ApplyConfiguration(new LeadConfig());

            LeadScreen.Data.Seeder.LeadScreenSeeder.SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }

}
