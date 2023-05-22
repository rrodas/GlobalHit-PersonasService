using System;
using System.Collections.Generic;
using domain.entities.persons;

namespace application.application.services.person
{
    public interface IPersonService
    {

        void Create(Person personEntitie);
        void Update(Person personEntitie);
        void DeletePerson(int id);
        Person GetPerson(int id);
        List<Person> GetPersons();
       
    }
}
