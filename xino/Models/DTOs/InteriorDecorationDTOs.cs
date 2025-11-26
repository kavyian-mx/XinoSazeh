using ENDPOINTs.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace ENDPOINTs.Models.DTOs
{
    public class InteriorDecorationCreateDTOs
    {

        [Display(Name = "تصویر هدر")]
        [Required(ErrorMessage = "تصویر هدر الزامی است")]
        public string HeaderImage { get; set; }

        [Display(Name = "آدرس پروژه")]
        [Required(ErrorMessage = "آدرس الزامی است")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "آدرس باید بین 5 تا 300 کاراکتر باشد")]
        public string Address { get; set; }

        [Display(Name = "Slug")]
        [Required(ErrorMessage = "Slug الزامی است")]
        [StringLength(200, ErrorMessage = "Slug حداکثر 200 کاراکتر باشد")]
        public string Slug { get; set; }

        [Display(Name = "نوع صفحه")]
        public string? PageType { get; set; }

        [Display(Name = "عنوان متا")]
        [StringLength(70, ErrorMessage = "عنوان متا حداکثر 70 کاراکتر باشد")]
        public string? MetaTitle { get; set; }

        [Display(Name = "توضیحات متا")]
        [StringLength(160, ErrorMessage = "توضیحات متا حداکثر 160 کاراکتر باشد")]
        public string? MetaDescription { get; set; }

        [Display(Name = "کلمات کلیدی متا")]
        [StringLength(200, ErrorMessage = "کلمات کلیدی متا حداکثر 200 کاراکتر باشد")]
        public string? MetaKeywords { get; set; }

        [Display(Name = "Canonical URL")]
        [StringLength(200, ErrorMessage = "Canonical URL حداکثر 200 کاراکتر باشد")]
        public string? CanonicalUrl { get; set; }

        [Display(Name = "گالری تصاویر")]
        [MinLength(1, ErrorMessage = "حداقل یک تصویر باید اضافه شود")]
        public virtual List<GalleryImageInteriorDecoration> GalleryImageInteriorDecoration { get; set; } = new();
    }
}


public class InteriorDecorationEditDTOs : InteriorDecorationCreateDTOs
{
    [Display(Name = "وضعیت حذف")]
    public bool IsDeleted { get; set; }

}

public class InteriorDecorationListDTOs
{
    public int Id { get; set; }

    public DateTime BuildDate { get; set; }

    public string HeaderImage { get; set; }

    public string Address { get; set; }

    public bool IsDeleted { get; set; }
    public string Slug { get; set; }



    public string? PageType { get; set; }


    public string? MetaTitle { get; set; }
    public string? MetaDescription { get; set; }
    public string? MetaKeywords { get; set; }
    public string? CanonicalUrl { get; set; }



    public DateTime? UpdatedAt { get; set; }



    public virtual List<GalleryImageInteriorDecoration> GalleryImageInteriorDecoration { get; set; }

}



