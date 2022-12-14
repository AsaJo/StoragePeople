using StoragePeople.Data;
using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.Repos
{
    public class DatabaseCountryRepo : ICountryRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DatabaseCountryRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public Country Create(Country country)
        {

            _peopleDbContext.Countries.Add(country);
            _peopleDbContext.SaveChanges();
            return country;
        }

        public List<Country> GetAll()
        {
            List<Country> countryList = _peopleDbContext.Countries.ToList();
            return countryList;
        }

        public Country FindById(int id)
        {
            return _peopleDbContext.Countries.Find(id);
        }
        public bool Update(Country country)
        {
            _peopleDbContext.Countries.Update(country);
            int countryUp = _peopleDbContext.SaveChanges();

            if (countryUp > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Country country)
        {
            _peopleDbContext.Countries.Remove(country);
            int countryDel = _peopleDbContext.SaveChanges();

            if (countryDel > 0)
            {
                return true;
            }
            return false;
        }
    }
}
