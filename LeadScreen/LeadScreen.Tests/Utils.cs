using LeadScreen.Data;
using Microsoft.EntityFrameworkCore;

namespace LeadScreen.Tests
{
    public class Utils
    {
        public static DbContextOptions<LeadScreenContext> GetOptions(string databaseName)
        {
            return new DbContextOptionsBuilder<LeadScreenContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;
        }
    }
}
