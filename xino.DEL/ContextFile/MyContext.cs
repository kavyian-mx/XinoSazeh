

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

    public DbSet<blug> Blugs { get; set; } = null!;

    public DbSet<Consultation> Consultations { get; set; } = null!;

    public DbSet<CurriculumVitae> CurriculumVitaes { get; set; } = null!;

    public DbSet<ExhibitionRule> ExhibitionRules { get; set; } = null!;


    public DbSet<InteriorDecoration> InteriorDecorations { get; set; } = null!;

    public DbSet<GalleryImageBlug> galleryImageBlugs { get; set; } = null!;

    public DbSet<Project> Projects { get; set; } = null!;


    public DbSet<Admin> Admins { get; set; } = null!;

    public DbSet<GalleryImageInteriorDecoration> ImageInteriorDecorations { get; set; } = null!;

    public DbSet<GalleryImageProject> GalleryImageProjects { get; set; } = null!;





}


