using System;
using System.Globalization;

namespace Exercise2
{
   public class Student : Person
   {
      public byte Course { get; set; }
      public string Group { get; set; }
      public float AverageScore { get; set; }
      public Student(string name, string patronomic, string lastname, DateTime date, byte course, string group, float averagescore) :
         base(name, patronomic, lastname, date)
      {
         Course = course;
         Group = group;
         AverageScore = averagescore;
      }
      public override string ToString()
      {
         return $"Student {Name} {Lastname} {Patronomic} {Age} {Date: MM\\/dd\\/yyyy} {Course} {Group} {AverageScore:f4}";
      }
      public static Student Parse(string text)  // text format: Name Patronomic Lastname Birthday[yyyy.mm.dd] course group averagescore
      {
         string[] s = text.Split(' ');
         return new Student(s[0], s[1], s[2], DateTime.ParseExact(s[3], "yyyy.MM.dd", CultureInfo.InvariantCulture), byte.Parse(s[4]), s[5], float.Parse(s[6]));
      }
   }
}
