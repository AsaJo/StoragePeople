using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.Repos
{
    public interface ICityRepo
    {
        City Create(City city);
        List<City> GetAll();
        City FindById(int id);

        bool Update(City city);
        bool Delete(City city);
    }
}
