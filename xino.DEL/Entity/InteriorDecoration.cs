
namespace xino.DEL.Entity;

public class InteriorDecoration:PageBaseSeo
{
    public int Id { get; set; }

    public DateTime BuildDate { get; set; }

    public string HeaderImage { get; set; }

    public string Address { get; set; }

    public bool IsDeleted { get; set; } 
    public string Slug { get; set; }

    
    public List<GalleryImageInteriorDecoration> GalleryImageInteriorDecoration { get; set; }
}





