using System;
using System.Globalization;

namespace Exercise2
{
   public class Person : IPerson
   {
      private static short counter = 0;
      public short Id { get;  }
      public string Name { get; }
      public string Patronomic { get; }
      public string Lastname { get; }
      public DateTime Date { get; }
      public int Age
      {
         get
         {
            var now = DateTime.Today;
            return now.Year - Date.Year - ((now.Month < Date.Month || now.Month == Date.Month && now.Day < Date.Day) ? 1 : 0); // Calulate age
         }
      }

      public Person(string name, string patronomic, string lastname, DateTime date)
      {
         Id = counter;
         counter++;
         Name = name;
         Patronomic = patronomic;
         Lastname = lastname;
         Date = date;
      }

      public override string ToString()
      {
         return $"{Name} {Lastname} {Patronomic} age: {Age} birthday: {Date: MM\\/dd\\/yyyy}";
      }
      public static Person Parse(string text) // text format: Name Lastname Patronomic Age Birthday[yyyy.mm.dd]
      {
         string[] s = text.Split(' ');
         return new Person(s[0], s[1], s[2], DateTime.ParseExact(s[3], "yyyy.MM.dd", CultureInfo.InvariantCulture));
      }
   }
}
