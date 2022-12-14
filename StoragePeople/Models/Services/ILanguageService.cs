using StoragePeople.Models.Enterties;
using StoragePeople.Models.ViewModels;

namespace StoragePeople.Models.Services
{
    public interface ILanguageService
    {
        Language Create(CreateLanguageViewModel createLanguage);
        List<Language> GetAll();
        List<Language> FindBy(string search);
        Language FindById(int id);
        bool Edit(int id, CreateLanguageViewModel editLanguage);
        bool Remove(int id);
    }
}
