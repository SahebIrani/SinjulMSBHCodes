using System.ComponentModel.DataAnnotations;

using DbLocalizationProvider;

namespace SinjulMSBH.Localization.ViewModels
{
    [LocalizedModel]
    public class UserViewModel
    {
        [Display(Name = "User name:", Description = "This is help text for the user name property")]
        [Required(ErrorMessage = "Name of the user is required!")]
        public string UserName { get; set; }

        [Display(Name = "Password:")]
        [Required(ErrorMessage = "Password is kinda required :)")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Please use longer password than 5 symbols!!")]
        public string Password { get; set; }
    }
}
