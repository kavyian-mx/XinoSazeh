using System.ComponentModel.DataAnnotations;

namespace ENDPOINTs.Models.DTOs
{
    public class ConsultationCreateDto
    {
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "نام را وارد کنید")]
        [StringLength(100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Display(Name = "سمت")]
        [Required(ErrorMessage = "سمت الزامی است")]
        [StringLength(100, MinimumLength = 3)]
        public string Role { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "شماره موبایل الزامی است")]
        [StringLength(12, MinimumLength = 10)]
        public string PhoneNumber { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل صحیح نیست")]
        [StringLength(100)]
        public string Email { get; set; }

        [Display(Name = "عنوان نمایشگاه")]
        [Required(ErrorMessage = "عنوان نمایشگاه الزامی است")]
        [StringLength(100)]
        public string Exhibition { get; set; }

        [Display(Name = "آدرس نمایشگاه")]
        [Required(ErrorMessage = "آدرس نمایشگاه الزامی است")]
        [StringLength(300, MinimumLength = 5)]
        public string AddressExhibition { get; set; }

        [Display(Name = "نام شرکت")]
        [Required(ErrorMessage = "نام شرکت الزامی است")]
        [StringLength(100, MinimumLength = 3)]
        public string Company { get; set; }

        [Display(Name = "تاریخ نمایشگاه")]
        [Required(ErrorMessage = "تاریخ نمایشگاه الزامی است")]
        public DateTime DateExhibition { get; set; }

        [Display(Name = "متراژ")]
        [Required(ErrorMessage = "متراژ الزامی است")]
        public int Meterage { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "توضیحات الزامی است")]
        [StringLength(300)]
        public string TextExhibition { get; set; }
    }
}
