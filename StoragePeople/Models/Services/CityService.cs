using StoragePeople.Models.Enterties;
using StoragePeople.Models.Repos;
using StoragePeople.Models.ViewModels;

namespace StoragePeople.Models.Services
{
    public class CityService:ICityService
    {
        private readonly ICityRepo _cityRepo;
        readonly ICountryRepo _countryRepo;
        public CityService(ICityRepo cityRepo, ICountryRepo countryRepo)
        {
            _cityRepo = cityRepo;
            _countryRepo = countryRepo;
        }
        public City Create(CreateCityViewModel createCity)
        {
            if (string.IsNullOrWhiteSpace(createCity.CityName))
            {
                return null;
            }

            City city = new City()
            {
                CityName = createCity.CityName,
                CountryId = createCity.CountryId
            };
            return _cityRepo.Create(city);
        }


        public List<City> GetAll()
        {
            return _cityRepo.GetAll();
        }

        public List<City> FindBy(string search)
        {
            List<City> searchCity = _cityRepo.GetAll();
            //
            foreach (City item in _cityRepo.GetAll())
            {
                if (item.CityName.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    searchCity.Add(item);
                }
            }
            //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
            if (searchCity.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return searchCity;
        }

        public City FindById(int Id)
        {
            City cityFound = _cityRepo.FindById(Id);
            return cityFound;
        }
        public bool Edit(int Id, CreateCityViewModel editCity)
        {
            City orginalCountry = FindById(Id);
            if (orginalCountry == null)
            {
                return false;
            }
            orginalCountry.CityName = editCity.CityName;
            return _cityRepo.Update(orginalCountry);
        }
        public bool Remove(int Id)
        {
            City cityToDelete = _cityRepo.FindById(Id);
            bool succses = _cityRepo.Delete(cityToDelete);
            return succses;
        }
    }
}
