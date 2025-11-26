using System.ComponentModel.DataAnnotations;

namespace ENDPOINTs.Models.DTOs
{
    public class ProjectCreateDTOs
    {


        [Display(Name = "عنوان پروژه")]
        [Required(ErrorMessage = "عنوان پروژه الزامی است")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "عنوان باید بین 3 تا 200 کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "تصویر هدر")]
        [Required(ErrorMessage = "تصویر هدر الزامی است")]
        public string HeaderImage { get; set; }

        [Display(Name = "Slug")]
        [Required(ErrorMessage = "Slug الزامی است")]
        [StringLength(200, ErrorMessage = "Slug حداکثر 200 کاراکتر باشد")]
        public string Slug { get; set; }

        [Display(Name = "متراژ پروژه")]
        [Required(ErrorMessage = "متراژ پروژه الزامی است")]
        [StringLength(50, ErrorMessage = "متراژ حداکثر 50 کاراکتر باشد")]
        public string ProjectSize { get; set; }

        [Display(Name = "سال پروژه")]
        [Required(ErrorMessage = "سال پروژه الزامی است")]
        [Range(1900, 2100, ErrorMessage = "سال پروژه باید بین 1900 تا 2100 باشد")]
        public int YearProject { get; set; }

        [Display(Name = "سبک پروژه")]
        [Required(ErrorMessage = "سبک پروژه الزامی است")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "سبک پروژه باید بین 3 تا 100 کاراکتر باشد")]
        public string StyleProject { get; set; }

        [Display(Name = "نمایشگاه مرتبط")]
        [StringLength(100, ErrorMessage = "نمایشگاه حداکثر 100 کاراکتر باشد")]
        public string ExhibitionProject { get; set; }

        [Display(Name = "گالری تصاویر")]
        [MinLength(1, ErrorMessage = "حداقل یک تصویر باید اضافه شود")]
        public virtual List<GalleryImageProject> GalleryImageProject { get; set; } = new();

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

    public class ProjectEditDTOs : ProjectCreateDTOs
    {
        [Display(Name = "وضعیت حذف")]
        public bool IsDeleted { get; set; }

    }


    public class ProjectListDTOs
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

        public string? PageType { get; set; }


        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public string? CanonicalUrl { get; set; }



        public DateTime? UpdatedAt { get; set; }


    }
}
