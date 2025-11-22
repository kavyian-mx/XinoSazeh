
using xino.DEL.Entity;


public class GalleryImageInteriorDecoration
{
    public int Id { get; set; }

    public string ImageUrl { get; set; }

    public int Order { get; set; }



    public virtual InteriorDecoration InteriorDecoration { get; set; }

    public int InteriorDecorationId { get; set; }


}


