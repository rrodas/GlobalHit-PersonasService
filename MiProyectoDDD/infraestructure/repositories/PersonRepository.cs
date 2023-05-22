using System;
using System.Collections.Generic;
using domain.entities.persons;
using domain.repositories.contracts.person;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace infraestructure.repositories
{
    public class PersonRepository : IPersonRepository
    {
        private CountryDBContext _context;
        public PersonRepository(CountryDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
       
        public void Create(Person personEntitie)
        {
            _context.Persons.Add(personEntitie);
            _context.SaveChanges();
        }

     
         public void DeletePerson(int id)
        {
            _context.Persons.Remove(_context.Persons.Find(id));
            _context.SaveChanges();
        }


          public List<Person> GetPersons()
        {
            var query =
            from Person in _context.Persons           
            select new { Person };
            var x = query.ToList();
            return _context.Persons.ToList();

        }


        public Person GetPerson(int id)
        {
            var query =
            from Person in _context.Persons           
            select new { Person};
            var x = query.ToList();
            return _context.Persons.Find(id);
        }
   

        public void Update(Person PersonEntitie)
        {
            _context.Persons.Attach(PersonEntitie); 
            _context.Entry(PersonEntitie).State = EntityState.Modified;           
            _context.SaveChanges();
        }
    }
}
