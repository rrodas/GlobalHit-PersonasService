
using System.Collections.Generic;
using domain.entities.persons;

namespace domain.repositories.contracts.person
{
    public interface IPersonRepository
    {
        void Create(Person personEntitie);
        void Update(Person personEntitie);
        void DeletePerson(int id);
        Person GetPerson(int id);
        List<Person> GetPersons();


    }
}
