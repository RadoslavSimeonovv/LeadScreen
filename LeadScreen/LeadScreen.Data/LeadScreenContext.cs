namespace LeadScreen.Data
{
    using LeadScreen.Data.Configuration;
    using LeadScreen.Data.Entities;
    using Microsoft.EntityFrameworkCore;

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

            // AppGreat.Data.Seeder.AppGreatSeeder.SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }

}
