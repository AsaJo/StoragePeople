using StoragePeople.Models.Enterties;
using StoragePeople.Models.ViewModels;

namespace StoragePeople.Models.Services
{
    public interface ICityService
    {
        City Create(CreateCityViewModel createCity);

        List<City> GetAll();

        List<City> FindBy(string search);

        City FindById(int id);

        bool Edit(int id, CreateCityViewModel cityViewModel);

        bool Remove(int id);
    }
}
