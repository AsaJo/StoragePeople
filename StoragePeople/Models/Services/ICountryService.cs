using StoragePeople.Models.Enterties;
using StoragePeople.Models.ViewModels;

namespace StoragePeople.Models.Services
{
    public interface ICountryService
    {
        Country Create(CreateCountryViewModel createCountry);

        List<Country> All();

        List<Country> FindBy(string search);

        Country FindById(int id);

        bool Edit(int id, CreateCountryViewModel editCountry);

        bool Remove(int id);
    }
}
