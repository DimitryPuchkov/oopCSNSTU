using System;

namespace Exercise2
{
   public class Student : Person
   {
      public byte Course { get; set; }
      public string Group { get; set; }
      public double AverageScore { get; set; }
      public Student(string name, string patronomic, string lastname, DateTime date, byte course, string group, double averagescore) :
         base(name, patronomic, lastname, date)
      {
         Course = course;
         Group = group;
         AverageScore = averagescore;
      }
      // TODO: Dasha write a metod ToString

   }
}
