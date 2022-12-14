using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.Repos
{
    public interface ICountryRepo
    {
        Country Create(Country country);
        List<Country> GetAll();
        Country FindById(int id);

        bool Update(Country country);
        bool Delete(Country country);
    }
}
