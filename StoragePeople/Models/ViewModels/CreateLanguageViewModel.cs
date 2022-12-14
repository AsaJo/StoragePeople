using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StoragePeople.Models.ViewModels
{
    public class CreateLanguageViewModel
    {
        [Required]
        [StringLength(80, MinimumLength = 1)]
        [Display(Name = "Language name")]
        public string? LanguageName { get; set; }
    }
}
