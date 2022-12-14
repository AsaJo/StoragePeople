namespace StoragePeople.Models.Enterties
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }
        //public List<PersonLanguage> PersonLanguages { get; set; }//Navigation Property

    }
}
