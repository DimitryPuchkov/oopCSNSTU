using System;
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
      // TODO: Dasha write a metod ToString

   }
}
