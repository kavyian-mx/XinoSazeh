using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using xino.DEL.Entity;

namespace ENDPOINTs.Models.DTOs
{
    public class ProjectCreateDTOs
    {
        [Display(Name = "عنوان پروژه")]
        [Required(ErrorMessage = "عنوان پروژه الزامی است")]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "تصویر هدر")]
        [Required(ErrorMessage = "تصویر هدر الزامی است")]
        public IFormFile HeaderImageFile { get; set; }

        // ✅ فقط برای ذخیره مسیر تصویر (از فرم نمیاد)
        public string? HeaderImage { get; set; }

        [Display(Name = "Slug")]
        [Required(ErrorMessage = "Slug الزامی است")]
        [StringLength(200)]
        public string Slug { get; set; }

        [Display(Name = "متراژ پروژه")]
        [Required(ErrorMessage = "متراژ پروژه الزامی است")]
        [StringLength(50)]
        public string ProjectSize { get; set; }

        [Display(Name = "سال پروژه")]
        [Required(ErrorMessage = "سال پروژه الزامی است")]
        [Range(1900, 2100)]
        public int YearProject { get; set; }

        [Display(Name = "سبک پروژه")]
        [Required(ErrorMessage = "سبک پروژه الزامی است")]
        [StringLength(100, MinimumLength = 3)]
        public string StyleProject { get; set; }

        [Display(Name = "نمایشگاه مرتبط")]
        [StringLength(100)]
        public string? ExhibitionProject { get; set; }

        [Display(Name = "گالری تصاویر")]
        [MinLength(1, ErrorMessage = "حداقل یک تصویر باید اضافه شود")]
        public List<IFormFile> GalleryImagesFiles { get; set; } = new();

        [Display(Name = "نوع صفحه")]
        public string? PageType { get; set; }

        [Display(Name = "عنوان متا")]
        [StringLength(70)]
        public string? MetaTitle { get; set; }

        [Display(Name = "توضیحات متا")]
        [StringLength(160)]
        public string? MetaDescription { get; set; }

        [Display(Name = "کلمات کلیدی متا")]
        [StringLength(200)]
        public string? MetaKeywords { get; set; }

        [Display(Name = "Canonical URL")]
        [StringLength(200)]
        public string? CanonicalUrl { get; set; }
    }

    public class ProjectEditDTOs : ProjectCreateDTOs
    {
        [Display(Name = "وضعیت حذف")]
        public bool IsDeleted { get; set; }

        // ✅ در حالت ویرایش آپلود جدید اجباری نیست
        public new IFormFile? HeaderImageFile { get; set; }
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

        public List<GalleryImageProject> GalleryImageProject { get; set; }

        public string? PageType { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public string? CanonicalUrl { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
