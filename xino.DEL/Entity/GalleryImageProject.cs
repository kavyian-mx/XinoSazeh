
using xino.DEL.Entity;


public class GalleryImageProject
{
    public int Id { get; set; }

    public string ImageUrl { get; set; }

    public int Order { get; set; }


    public virtual Project Project { get; set; }

    public int ProjectId { get; set; }


}


