

namespace xino.DEL.Entity;

   public class blug: PageBaseSeo
{
    public int Id { get; set; }

    public string title { get; set; }


    public string Slug { get; set; }
    public string ImageHeader { get; set; }

    public string TitleBlug { get; set; }

    public blugCategory blugCategory { get; set; }

    public string BodyBlug { get; set; }

    public string Suore { get; set; }

    public DateTime BuildDate { get; set; }


   
    public bool IsDeleted { get; set; }

    public List<GalleryImageBlug> GalleryImageBlug { get; set; }

}


public enum blugCategory
{
    News,          // اخبار
    Article,       // مقالات
    TopExhibition  // غرفه‌های برتر
}

