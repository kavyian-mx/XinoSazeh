using System;
using System.ComponentModel.DataAnnotations;
using xino.DEL.Entity;

public class CurriculumVitaeCreateDto
{
    [Display(Name = "نام و نام خانوادگی")]
    [Required(ErrorMessage = "نام و نام خانوادگی الزامی است")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 100 کاراکتر باشد")]
    public string FullName { get; set; }

    [Display(Name = "نام پدر")]
    [Required(ErrorMessage = "نام پدر الزامی است")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "نام پدر باید بین 3 تا 100 کاراکتر باشد")]
    public string FatherName { get; set; }

    [Display(Name = "شماره شناسنامه / کد ملی")]
    [Required(ErrorMessage = "شماره شناسنامه الزامی است")]
    [StringLength(20, MinimumLength = 5, ErrorMessage = "شماره شناسنامه باید بین 5 تا 20 کاراکتر باشد")]
    public string IDNumber { get; set; }

    [Display(Name = "سمت شغلی")]
    [Required(ErrorMessage = "سمت شغلی الزامی است")]
    public JobPosition JobPosition { get; set; }

    [Display(Name = "شهر")]
    [Required(ErrorMessage = "شهر الزامی است")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "نام شهر باید بین 2 تا 100 کاراکتر باشد")]
    public string City { get; set; }

    [Display(Name = "جنسیت")]
    [Required(ErrorMessage = "جنسیت الزامی است")]
    public Gender Gender { get; set; }

    [Display(Name = "شماره موبایل")]
    [Required(ErrorMessage = "شماره موبایل الزامی است")]
    [RegularExpression(@"^09\d{9}$", ErrorMessage = "فرمت شماره موبایل صحیح نیست. مثال: 09123456789")]
    public string PhoneNumber { get; set; }

    [Display(Name = "ایمیل")]
    [Required(ErrorMessage = "ایمیل الزامی است")]
    [EmailAddress(ErrorMessage = "فرمت ایمیل صحیح نیست")]
    public string Email { get; set; }

    [Display(Name = "فایل رزومه")]
    public string File { get; set; }

    [Display(Name = "توضیحات")]
    [StringLength(300, ErrorMessage = "توضیحات حداکثر 300 کاراکتر است")]
    public string Text { get; set; }
}

public class CurriculumVitaeIsCkeck
{
    public bool IsChacket { get; set; }

}


public class CurriculumVitaeListDto
{
    public int Id { get; set; }
    public DateTime BuildDate { get; set; }
    public string FullName { get; set; }
    public string FatherName { get; set; }
    public string IDNumber { get; set; }
    public string JobPosition { get; set; } // متن Enum
    public string City { get; set; }
    public string Gender { get; set; }      // متن Enum
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string File { get; set; }
    public string Text { get; set; }
   
}

public enum JobPosition
{
    ArchitectureDepartment,   // واحد معماری
    SalesDepartment,          // واحد فروش
    AdministrationDepartment  // واحد اداری
}

public enum Gender
{
    Male,
    Female
}

