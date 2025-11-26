namespace ENDPOINTs.Models.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class BlugCreateDTOs
    {
        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "عنوان الزامی است")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "عنوان باید بین 5 تا 200 کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "Slug")]
        [Required(ErrorMessage = "Slug الزامی است")]
        [StringLength(200, ErrorMessage = "Slug حداکثر 200 کاراکتر باشد")]
        public string Slug { get; set; }

        [Display(Name = "تصویر هدر")]
        [Required(ErrorMessage = "تصویر هدر الزامی است")]
        public string ImageHeader { get; set; }

        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "عنوان بلاگ الزامی است")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "عنوان بلاگ باید بین 5 تا 300 کاراکتر باشد")]
        public string TitleBlug { get; set; }

        [Display(Name = "دسته‌بندی")]
        [Required(ErrorMessage = "دسته‌بندی الزامی است")]
        public blugCategory BlugCategory { get; set; }

        [Display(Name = "متن بلاگ")]
        [Required(ErrorMessage = "متن بلاگ الزامی است")]
        public string BodyBlug { get; set; }

        [Display(Name = "منبع")]
        [StringLength(200, ErrorMessage = "منبع حداکثر 200 کاراکتر باشد")]
        public string Suore { get; set; }


        [Display(Name = "گالری تصاویر")]
        [MinLength(1, ErrorMessage = "حداقل یک تصویر باید اضافه شود")]
        public virtual List<GalleryImageBlug> GalleryImageBlug { get; set; } = new();

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
    }

    public class BlugEditDTOs: BlugCreateDTOs
    {
        [Display(Name = "وضعیت حذف")]
        public bool IsDeleted { get; set; }

    }

    public class BlugListDTOs
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

        public virtual List<GalleryImageBlug> GalleryImageBlug { get; set; }

        public string? PageType { get; set; }


        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public string? CanonicalUrl { get; set; }



         public DateTime? UpdatedAt { get; set; }


    }


    public enum blugCategory
    {
        News,          // اخبار
        Article,       // مقالات
        TopExhibition  // غرفه‌های برتر
    }
}
