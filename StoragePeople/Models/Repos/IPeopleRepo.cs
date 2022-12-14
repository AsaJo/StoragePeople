using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.Repos
{
    public interface IPeopleRepo
    {
        // C Create

        Person Create(Person person); //

        // R 
        List<Person> GetAll();//

        Person GetById(int id);// 


        // U Update the people list
        bool Update(Person person);// 


        // D Delete a person from the list
        void Delete(Person person);
    }
}
