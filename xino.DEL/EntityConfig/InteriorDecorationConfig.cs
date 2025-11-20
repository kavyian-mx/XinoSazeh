

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xino.DEL.Entity;

namespace xino.DEL.EntityConfig;

public class InteriorDecorationConfig : IEntityTypeConfiguration<InteriorDecoration>
{
    public void Configure(EntityTypeBuilder<InteriorDecoration> builder)
    {
        builder.Property(x => x.HeaderImage).IsRequired();
        builder.Property(c => c.Address).IsRequired(false);
        builder.Property(x => x.Slug).IsRequired().HasMaxLength(25);

        builder.Property(x => x.Slug)
       .IsRequired()
       .HasMaxLength(300)
       .HasColumnType("varchar(300)")
       .IsUnicode(false);

        builder.HasIndex(x => x.Slug).IsUnique();
        builder.HasIndex(x => new { x.IsDeleted, x.BuildDate });
    }
}
