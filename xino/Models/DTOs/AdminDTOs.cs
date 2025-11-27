using System.ComponentModel.DataAnnotations;

namespace ENDPOINTs.Models.DTOs
{
    public class AdminCreateDTOs
    {
        [Required(ErrorMessage = "نام کاربری الزامی است")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام کاربری باید بین 3 تا 50 کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = "رمز عبور باید حداقل 8 کاراکتر شامل حرف بزرگ، حرف کوچک، عدد و کاراکتر خاص باشد")]
        public string Password { get; set; }
    }

    public class AdminListDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSuperAdmin { get; set; }
        public DateTime BuildDate { get; set; }
    }

    public class AdminEditDTOs : AdminCreateDTOs
    {
        public bool IsSuperAdmin { get; set; }
    }
}
