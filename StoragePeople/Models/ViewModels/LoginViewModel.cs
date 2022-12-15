using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StoragePeople.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

