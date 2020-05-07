using System.ComponentModel.DataAnnotations;

using DbLocalizationProvider;

namespace MyDbLocalizaion.Models
{
    [LocalizedModel]
    public class AddressViewModel
    {
        [Required(ErrorMessage = "Street name is also required")]
        public string Street { get; set; }
    }
}
