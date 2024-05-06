using System.ComponentModel.DataAnnotations;

namespace ghabzinow.ViewModel.user
{
    public class RigisterDto
    {
        public string Name { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "وارد کردن نام کاربری الزامی هست")]
        public string Family { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "وارد کردن ایمیل الزامی هست")]
        public string Phone { get; set; }
        [MinLength(5, ErrorMessage = "حداقل پنح کارکتر را وارد کنید")]
        [Required(ErrorMessage = "وارد کردن تکرار پسورد الزامی هست")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "رمز کاربری همسان نیست")]

        [Required(ErrorMessage = "وارد کردن تکرار پسورد الزامی هست")]
        public string ReportPassword { get; set; }
        public string Email { get; set; }

    }
}
