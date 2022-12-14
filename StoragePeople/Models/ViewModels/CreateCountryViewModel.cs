using StoragePeople.Models.Enterties;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StoragePeople.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        [Required(ErrorMessage = "Enter a country, it is Required!")]
        [StringLength(80, MinimumLength = 1)]
        [Display(Name = "Country")]
        public string CountryName { get; set; }
        public List<City> CityList { get; set; }
        public CreateCountryViewModel() { CityList = new List<City>(); }
    }
}
