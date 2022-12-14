using Microsoft.EntityFrameworkCore;
using StoragePeople.Data;
using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.Repos
{
    public class DatabaseCityRepo : ICityRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DatabaseCityRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public City Create(City city)
        {

            _peopleDbContext.Cities.Add(city);
            _peopleDbContext.SaveChanges();
            return city;
        }

        public List<City> GetAll()
        {
            return _peopleDbContext.Cities.Include(city => city.Country).ToList();

        }

        public City FindById(int id)
        {
            return _peopleDbContext.Cities.SingleOrDefault(city => city.Id == id);
        }

        public bool Update(City city)
        {
            _peopleDbContext.Cities.Update(city);
            int resultUp = _peopleDbContext.SaveChanges();
            if (resultUp == 0)
            {
                return false;
            }
            return true;


        }
        public bool Delete(City city)
        {
            _peopleDbContext.Cities.Remove(city);
            int resultDel = _peopleDbContext.SaveChanges();
            if (resultDel == 0)
            {
                return false;
            }
            return true;
        }
    }
}
