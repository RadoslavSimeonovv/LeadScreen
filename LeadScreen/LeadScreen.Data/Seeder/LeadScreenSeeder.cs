using LeadScreen.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeadScreen.Data.Seeder
{
    /// <summary>
    /// Static seeder for subarea entity
    /// </summary>
    public static class LeadScreenSeeder
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subarea>().HasData(
               new Subarea
               {
                   Id = 1,
                   Name = "Mladost 1",
                   Pincode = "1784"
                   
               });

            modelBuilder.Entity<Subarea>().HasData(
               new Subarea
               {
                   Id = 2,
                   Name = "Lyulin",
                   Pincode = "1336"
               });

            modelBuilder.Entity<Subarea>().HasData(
            new Subarea
            {
                Id = 3,
                Name = "Musagenitsa",
                Pincode = "1797"
            });

            modelBuilder.Entity<Subarea>().HasData(
             new Subarea
             {
                 Id = 4,
                 Name = "Nadejda",
                 Pincode = "1220"
             });

            modelBuilder.Entity<Subarea>().HasData(
              new Subarea
              {
                  Id = 5,
                  Name = "Obelya",
                  Pincode = "1387"
              });
        }
    }
}
