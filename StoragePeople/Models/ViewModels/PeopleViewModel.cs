using StoragePeople.Models.Enterties;

namespace StoragePeople.Models.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> PeopleListView { get; set; }

        public string FilterString { get; set; }

        public PeopleViewModel()
        { PeopleListView = new List<Person>(); }
    }
}
