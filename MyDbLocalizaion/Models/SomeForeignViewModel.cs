using System.ComponentModel.DataAnnotations;

namespace MyDbLocalizaion.Models
{
    public class SomeForeignViewModel
    {
        [Display(Name = "Property 1")]
        public string Property1 { get; set; } = "Property 1";
    }
}
