using StoragePeople.Models.Enterties;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StoragePeople.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name = "First and last name")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string? PhoneNumber { get; set; }

        [Display(Name = "City")]
        [Required]
        public int CityId { get; set; }

        public List<City>? Cities { get; set; }
    }
}
