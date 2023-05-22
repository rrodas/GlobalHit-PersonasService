using System;
using System.Collections.Generic;
using domain.entities.persons;
using DomainCotract = domain.repositories.contracts.person;

namespace application.application.services.person
{
    public class PersonService : IPersonService
    {
        
        readonly DomainCotract.IPersonRepository _domainICotract;
       
         public PersonService( DomainCotract.IPersonRepository domainICotract)
        {            
            this._domainICotract = domainICotract;
        }

     
        public void Create(Person personEntitie)
        {
            _domainICotract.Create(personEntitie);
        }


         public void DeletePerson(int id)
        {
            _domainICotract.DeletePerson(id);
        }

        public List<Person> GetPersons()
        {
            return _domainICotract.GetPersons();
        }

  
         public Person GetPerson(int id)
        {
            return _domainICotract.GetPerson(id);
        }
       

        public void Update(Person personEntitie)
        {
            _domainICotract.Update(personEntitie);
        }
    }
}
