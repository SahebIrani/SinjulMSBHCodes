using System.ComponentModel.DataAnnotations;

using DbLocalizationProvider;
using DbLocalizationProvider.Abstractions;

using MyDbLocalizaion.Resources;

namespace MyDbLocalizaion
{
    [LocalizedModel]
    public class ModelForSinjulMSBH
    {
        [Display(Name = "Title:", Description = "This is description of Title field")]
        [Required(ErrorMessage = "Title of the user is required!")]
        [WeirdCustom("Weird Title attribute")]
        [StringLength(22, MinimumLength = 4, ErrorMessage = "Please use longer Title than 4 symbols!!")]
        public string Title { get; set; }
    }

    [LocalizedResource]
    public class ResourcesForSinjulMSBH
    {
        public string TitleHeader { get; set; } = "This is title header";

        [TranslationForCulture("Jackslater In Swedish and English (SV)", "sv")]
        [TranslationForCulture("Jackslater In Swedish and English (EN)", "en")]
        public static string Jackslater => "Jackslater In Swedish and English (INV)";
    }
}
