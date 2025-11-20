

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xino.DEL.EntityConfig;

public class GalleryImageProjectConfig : IEntityTypeConfiguration<GalleryImageProject>
{
    public void Configure(EntityTypeBuilder<GalleryImageProject> builder)
    {
        builder.HasOne(x => x.Project).WithMany(x => x.GalleryImageProject).HasForeignKey(x => x.ProjectId);

        builder.HasIndex(x => new { x.ProjectId, x.Order });
    }
}

