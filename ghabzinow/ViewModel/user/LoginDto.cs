using System.ComponentModel.DataAnnotations;

namespace ghabzinow.ViewModel.user
{
    public class LoginDto
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "{0} الزامی می باشد.")]
        public string Phone { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "{0} الزامی می باشد.")]
        public string Password { get; set; }
        public int Day { get; set; }
    }
}
