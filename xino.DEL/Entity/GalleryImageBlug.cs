
using xino.DEL.Entity;


public class GalleryImageBlug
{
    public int Id { get; set; }

    public string ImageUrl { get; set; }

    public int Order { get; set; }


    public virtual blug blug { get; set; }

    public int BlugId { get; set; }


}


