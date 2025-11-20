

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xino.DEL.Entity;

namespace xino.DEL.EntityConfig;

public class ConsultationConfig : IEntityTypeConfiguration<Consultation>
{
    public void Configure(EntityTypeBuilder<Consultation> builder)
    {
        builder.Property(x => x.BuildDate).HasDefaultValueSql("GETDATE()");
        builder.Property(x => x.IsChacket).HasDefaultValue(false);
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Role).IsRequired().HasMaxLength(100);
        builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Exhibition).IsRequired().HasMaxLength(100);
        builder.Property(x => x.AddressExhibition).IsRequired().HasMaxLength(300);
        builder.Property(x => x.Company).IsRequired().HasMaxLength(100);
        builder.Property(x => x.TextExhibition).IsRequired().HasMaxLength(300);
        builder.Property(x => x.Meterage).IsRequired();

        builder.HasIndex(x => new { x.IsChacket, x.BuildDate });
        builder.HasIndex(x => x.PhoneNumber); 

    }
}

