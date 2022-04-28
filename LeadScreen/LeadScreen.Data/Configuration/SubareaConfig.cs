namespace LeadScreen.Data.Configuration
{
    using LeadScreen.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SubareaConfig : IEntityTypeConfiguration<Subarea>
    {
        public void Configure(EntityTypeBuilder<Subarea> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}
