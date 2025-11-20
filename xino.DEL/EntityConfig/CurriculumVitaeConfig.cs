
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xino.DEL.Entity;

namespace xino.DEL.EntityConfig;

public class CurriculumVitaeConfig : IEntityTypeConfiguration<CurriculumVitae>
{
    public void Configure(EntityTypeBuilder<CurriculumVitae> builder)
    {
        builder.Property(x => x.BuildDate).HasDefaultValueSql("GETDATE()");
        builder.Property(x => x.IsChacket).HasDefaultValue(false);
        builder.Property(x => x.City).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(120);
        builder.Property(x => x.FatherName).IsRequired().HasMaxLength(120);
        builder.Property(x => x.IDNumber).IsRequired().HasMaxLength(20);
        builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
        builder.Property(x => x.File).IsRequired();
        builder.Property(x => x.Text).IsRequired().HasMaxLength(500);

    }
}

