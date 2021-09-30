using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
   public enum Degrees : byte
   {
      HeadOfDepartment,
      Professor,
      ProfessorAssistant,
      Teacher,
      LabAssistant
   }

   public class Teacher : Person
   {
      public Degrees Degree { get; set; }
      public string Department { get; set; }
      public float Seniority { get; set; }
      public Teacher(string name, string patronomic, string lastname, DateTime date, string department, float seniority, Degrees degree)
         : base(name, patronomic, lastname, date)
      {
         Department = department;
         Seniority = seniority;
         Degree = degree;
      }
      public override string ToString()
      {
         return $"Teacher {Name} {Lastname} {Patronomic} {Age} {Date: MM\\/dd\\/yyyy} {Department} {Seniority:f1} {Degree}";
      }
      public static Teacher Parse(string text)  // text format: Name Patronomic Lastname Birthday[yyyy.mm.dd] department seniority degree
      {
         string[] s = text.Split(' ');
         Degrees degree;
         switch (s[6])
         {
            case "HeadOfDepartment":
               degree = Degrees.HeadOfDepartment;
               break;
            case "Professor":
               degree = Degrees.Professor;
               break;
            case "ProfessorAssistant":
               degree = Degrees.ProfessorAssistant;
               break;
            case "Teacher":
               degree = Degrees.Teacher;
               break;
            case "LabAssistant":
               degree = Degrees.LabAssistant;
               break;
            default:
               degree = Degrees.Teacher;
               break;
         }
         return new Teacher(s[0], s[1], s[2], DateTime.ParseExact(s[3], "yyyy.MM.dd", CultureInfo.InvariantCulture), s[4], float.Parse(s[5]), degree);
      }
   }
}
