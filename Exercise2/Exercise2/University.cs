using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
   class University : IUniversity
   {
      List<IPerson> people = new List<IPerson>();

      public IEnumerable<IPerson> Persons
      {
         get
         {
            return people.OrderBy(p => p.Date);
         }
      }

      public IEnumerable<Student> Students
      {
         get
         {
            return people.OfType<Student>().OrderBy(p => p.Date);
         }
      }

      public IEnumerable<Teacher> Teachers
      {
         get
         {
            return people.OfType<Teacher>().OrderBy(p => p.Date);
         }
      }

      public void Add(IPerson person)
      {
         //if(person is Student || person is Teacher)
         people.Add(person);
      }

      public IEnumerable<IPerson> FindByLastName(string lastName)
      {
         throw new NotImplementedException();

      }

      public void Remove(IPerson person)
      {
         
      }
   }
}
