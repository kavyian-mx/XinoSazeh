

namespace xino.DEL.Entity;

  public  class Project:PageBaseSeo
    {
    public int Id { get; set; }

    public DateTime BuildDate { get; set; } 

    public string Title { get; set; }

    public string HeaderImage { get; set; }

    public string Slug { get; set; }

    public string ProjectSize { get; set; }

    public int YearProject { get; set; }

    public string StyleProject { get; set; }

    public string ExhibitionProject { get; set; }

    public bool IsDeleted { get; set; }

    public virtual List<GalleryImageProject> GalleryImageProject { get; set; }


}

