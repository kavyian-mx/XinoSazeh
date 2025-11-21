

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xino.DEL.Entity;

namespace xino.DEL.EntityConfig;

public class ProjectConfig : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.Property(x => x.BuildDate).HasDefaultValueSql("GETDATE()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        builder.Property(x => x.HeaderImage).IsRequired();
        builder.Property(x => x.ProjectSize).IsRequired().HasMaxLength(125);
        builder.Property(x => x.YearProject).IsRequired();
        builder.Property(x => x.StyleProject).IsRequired();
        builder.Property(x => x.ExhibitionProject).IsRequired();

        builder.Property(x => x.Slug)
       .IsRequired()
       .HasMaxLength(300)
       .HasColumnType("varchar(300)")
       .IsUnicode(false);

        builder.HasIndex(x => x.Slug).IsUnique();
        builder.HasIndex(x => new { x.IsDeleted, x.BuildDate });  
        builder.HasIndex(x => x.YearProject);

    }
}

