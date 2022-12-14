using StoragePeople.Models.Enterties;
using StoragePeople.Models.ViewModels;

namespace StoragePeople.Models.Services
{
    public interface IPeopleService
    {
        Person Create(CreatePersonViewModel createPerson);
        List<Person> GetAll();
        List<Person> Search(string Search);
        Person FindById(int id);
        //Person Edit(Person person);
        bool Edit(int id, CreatePersonViewModel editPerson);
        //bool Remove(Person person);
        void Remove(int id);
        //PersonLanguageViewModel PersonLanguage(Person person);
        //void RemoveLanguage(Person person, int languageId);
        //void AddLanguage(Person person, int languageId);
    }
}
