using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using xino.DEL.Entity;

namespace xino.DEL.EntityConfig
{
   public class blugConfig : IEntityTypeConfiguration<blug>
    {
        public void Configure(EntityTypeBuilder<blug> builder)
        {
            builder.Property(x => x.title).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Slug).IsRequired().HasMaxLength(25);
            builder.Property(x => x.ImageHeader).IsRequired();
            builder.Property(x => x.TitleBlug).IsRequired().HasMaxLength(100);
            builder.Property(x => x.BodyBlug).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Suore).IsRequired().HasMaxLength(100);
            builder.Property(x => x.BuildDate).HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);




        }
    }
}
