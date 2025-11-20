

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xino.DEL.EntityConfig;

class GalleryImageInteriorDecorationConfig : IEntityTypeConfiguration<GalleryImageInteriorDecoration>
{
    public void Configure(EntityTypeBuilder<GalleryImageInteriorDecoration> builder)
    {
        builder.HasOne(x => x.InteriorDecoration).WithMany(x => x.GalleryImageInteriorDecoration).HasForeignKey(x => x.InteriorDecorationId);
    }
}

