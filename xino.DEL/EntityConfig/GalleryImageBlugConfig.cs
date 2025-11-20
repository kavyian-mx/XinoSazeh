

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xino.DEL.EntityConfig;

public class GalleryImageBlugConfig : IEntityTypeConfiguration<GalleryImageBlug>
{
    public void Configure(EntityTypeBuilder<GalleryImageBlug> builder)
    {
        builder.HasOne(x => x.blug).WithMany(x => x.GalleryImageBlug).HasForeignKey(x => x.BlugId);
    }
}

