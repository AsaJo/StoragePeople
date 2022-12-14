using Microsoft.EntityFrameworkCore;
using StoragePeople.Data;
using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.Repos
{
    public class DatabasePeopleRepo:IPeopleRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DatabasePeopleRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public Person Create(Person person)
        {
            _peopleDbContext.People.Add(person);
            _peopleDbContext.SaveChanges();

            return person;
        }


        public List<Person> GetAll()
        {
            return _peopleDbContext.People.Include(person => person.City).ThenInclude(person => person.Country).ToList();

        }

        public Person GetById(int id)
        {
            return _peopleDbContext.People.Include(person => person.City).ThenInclude(person => person.Country).SingleOrDefault(person => person.Id == id);
        }

        public bool Update(Person person)
        {
            _peopleDbContext.People.Update(person);
            int result = _peopleDbContext.SaveChanges();
            if (result == 0)
            {
                return false;

            }
            return true;
        }
        public void Delete(Person person)
        {
            _peopleDbContext.People.Remove(person);
            _peopleDbContext.SaveChanges();


        }
    }
}


