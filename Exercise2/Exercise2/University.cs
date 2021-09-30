using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
   class University : IUniversity
   {
      List<IPerson> people = new List<IPerson>();
      public bool SortMode = false;

      public IEnumerable<IPerson> Persons
      {
         get
         {
            if (!SortMode)
                return people.OrderBy(p => p.Date);
            else
                return people.OrderByDescending(p => p.Date);
         }
      }

      public IEnumerable<Student> Students
      {
         get
         {
            if (!SortMode)
                return people.OfType<Student>().OrderBy(p => p.Date);
            else
                return people.OfType<Student>().OrderByDescending(p => p.Date);
         }
      }

      public IEnumerable<Teacher> Teachers
      {
         get
         {
            if (!SortMode)
                return people.OfType<Teacher>().OrderBy(p => p.Date);
            else 
                return people.OfType<Teacher>().OrderByDescending(p => p.Date);
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

      public IEnumerable<Teacher> FindByDepartment(string text)
      {
         return people.OfType<Teacher>().Where(p => p.Department == text).OrderBy(p => p.Lastname);
      }

      public void Remove(IPerson person)
      {
         people.Remove(person);
      }
   }
}
