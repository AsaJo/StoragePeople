using StoragePeople.Models.Enterties;
using StoragePeople.Models.Repos;
using StoragePeople.Models.ViewModels;

namespace StoragePeople.Models.Services
{

    public class CountryService : ICountryService
    {
        private readonly ICountryRepo _countryRepo;

        public CountryService(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }
        public Country Create(CreateCountryViewModel createCountry)
        {
            if (string.IsNullOrWhiteSpace(createCountry.CountryName))
            {
                return null;
            }

            return _countryRepo.Create(new Country(createCountry.CountryName));
        }

        public List<Country> All()
        {
            return _countryRepo.GetAll();
        }

        public List<Country> FindBy(string search)
        {
            List<Country> searchCountry = _countryRepo.GetAll();
            //
            foreach (Country item in _countryRepo.GetAll())
            {
                if (item.CountryName.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    searchCountry.Add(item);
                }
            }
            //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
            if (searchCountry.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return searchCountry;
        }

        public Country FindById(int id)
        {
            Country countryFound = _countryRepo.FindById(id);
            return countryFound;
        }
        public bool Edit(int id, CreateCountryViewModel editCountry)
        {
            Country orginalCountry = FindById(id);
            if (orginalCountry == null)
            {
                return false;
            }
            orginalCountry.CountryName = editCountry.CountryName;
            return _countryRepo.Update(orginalCountry);
        }

        public bool Remove(int id)
        {
            Country countryToDelete = _countryRepo.FindById(id);
            bool succses = _countryRepo.Delete(countryToDelete);
            return succses;
        }

    }
}

