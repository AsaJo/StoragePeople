using System.ComponentModel.DataAnnotations;

namespace StoragePeople.Models.Enterties
{
    public class Country
    {
        [Key]
        public int Id { get; set; }// Needs to be set in Cityclass 
        public string? CountryName { get; set; }
        public Country( string? countryName)
        {
            CountryName = countryName;
           
        }
    
        public List<City>? Cities { get; set; }//Navigation Property

    }
}
