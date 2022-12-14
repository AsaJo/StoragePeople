using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoragePeople.Models.Enterties
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string? CityName { get; set; }

        public List<Person> People { get; set; }//Navigation Property

        public int CountryId { get; set; }// PeopleDbContext ForeignKey
        public Country? Country { get; set; }//Navigation Property
    }
}
