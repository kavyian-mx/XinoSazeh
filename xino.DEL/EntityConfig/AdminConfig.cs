using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xino.DEL.Entity;

namespace xino.DEL.EntityConfig;

public class AdminConfig : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

        builder.Property(x => x.Password).IsRequired();

        builder.Property(x => x.BuildDate)
       .HasDefaultValueSql("GETDATE()");

        builder.Property(x => x.IsSuperAdmin)
       .HasDefaultValue(false);

    }
}

