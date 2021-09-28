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
            // TODO: Dasha please add feature for sort people by ascending or descending
            return people.OrderBy(p => p.Date);
         }
      }

      public IEnumerable<Student> Students
      {
         get
         {
            // TODO: Dasha please add feature for sort students by ascending or descending
            return people.OfType<Student>().OrderBy(p => p.Date);
         }
      }

      public IEnumerable<Teacher> Teachers
      {
         get
         {
            // TODO: Dasha please add feature for sort teacher by ascending or descending
            return people.OfType<Teacher>().OrderBy(p => p.Date);
         }
      }

      public void Add(IPerson person)
      {
         if(person is Student || person is Teacher)
            people.Add(person);
      }

      public IEnumerable<IPerson> FindByLastName(string lastName)
      {
         return people.Where(p => p.Lastname == lastName).OrderBy(p => p.Name);
      }

      public void Remove(IPerson person)
      {
         people.Remove(person);
      }
   }
}
