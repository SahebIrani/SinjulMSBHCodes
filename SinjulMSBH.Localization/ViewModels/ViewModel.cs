using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using SinjulMSBH.Localization.Resources;

namespace SinjulMSBH.Localization.ViewModels
{
    public class ViewModel
    {
        [Required(ErrorMessage = "ErrorMessage", ErrorMessageResourceName = "ErrorMessage", ErrorMessageResourceType = typeof(Resource))]
        [Display(ResourceType = typeof(Resource), Name = nameof(FullName))]
        public string FullName { get; set; }

        [DisplayName(nameof(Age))]
        public short Age { get; set; }
    }
}
