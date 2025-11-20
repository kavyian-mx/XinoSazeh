

using Microsoft.EntityFrameworkCore;
using xino.DEL.Entity;

namespace xino.DEL.ContextFile;

public class MyContext(DbContextOptions<MyContext> options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<blug> Blugs { get; set; }

    public DbSet<Consultation> Consultations { get; set; }

    public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }

    public DbSet<ExhibitionRule> ExhibitionRules { get; set; }


    public DbSet<InteriorDecoration> InteriorDecorations { get; set; }

    public DbSet<GalleryImageBlug> galleryImageBlugs { get; set; }

    public DbSet<Project> Projects { get; set; }

    
    public DbSet<Admin> Admins { get; set; }

    public DbSet<GalleryImageInteriorDecoration> ImageInteriorDecorations { get; set; }

    public DbSet<GalleryImageProject> GalleryImageProjects { get; set; }





}


