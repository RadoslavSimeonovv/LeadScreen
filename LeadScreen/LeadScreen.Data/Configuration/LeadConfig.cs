namespace LeadScreen.Data.Configuration
{
    using LeadScreen.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class LeadConfig : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}
