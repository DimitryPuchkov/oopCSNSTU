using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercise2
{
   internal class Program
   {
      University uni = new University();
      public void getHelp()
      {
         Console.WriteLine("Commands:\n add - adding person to University");
         Console.WriteLine(" revove - removing person from University");
         Console.WriteLine(" find - searching people from University");
         Console.WriteLine(" list - printing list of people from University");
         Console.WriteLine(" exit - exiting from program");
         Console.WriteLine(" help - printing this list");
        // Console.WriteLine(" [comand] --help  - manual for comand");
      }
      public void addPerson(string s)
      {
         if(s != "s" || s != "t")
         {
            Console.WriteLine($" -{s} Impossible parameter");
            return;
         }
         Console.Write("Name: ");
         string name = Console.ReadLine();
         Console.Write("Patronomic: ");
         string patronomic = Console.ReadLine();
         Console.Write("Lastname: ");
         string lastname = Console.ReadLine();
         Console.Write("Date of birth: [yyyy.mm.dd]");
         DateTime date = DateTime.ParseExact(Console.ReadLine(), "yyyy.MM.dd", CultureInfo.InvariantCulture);
         if(s == "t")
         {
            Console.Write("Department: ");
            string department =  Console.ReadLine();
            Console.Write("Seniority: ");
            float seniority = float.Parse(Console.ReadLine());
            Console.Write("Degree (1 - HeadOfDepartment, 2 - Professor, 3 - ProfessorAssistant, 4 - Teacher, 5 - LabAssistant): ");
            Degrees degree = (Degrees)byte.Parse(Console.ReadLine());
            uni.Add(new Teacher(name, patronomic, lastname, date, department, seniority, degree));
         }
         else
         {
            Console.Write("Course: ");
            byte course = byte.Parse(Console.ReadLine());
            Console.Write("Group: ");
            string group = Console.ReadLine();
            Console.Write("Averagescore: ");
            float averagescore = float.Parse(Console.ReadLine());
            uni.Add(new Student(name, patronomic, lastname, date, course, group, averagescore));
         }
      }
      public void remove(string lastname)
      {
         var rmlist = uni.FindByLastName(lastname);
         if(rmlist.Count() == 1)
         {
            uni.Remove(rmlist.First());
            return;
         }
         foreach (var l in rmlist)
         {
            Console.WriteLine(l.ToString());
         }
         Console.Write("Enter a number of person, who neet to remove");
         int i = Int32.Parse(Console.ReadLine());
         uni.Remove(rmlist.ElementAt(i - 1));
         return;
      }
      static void Main(string[] args)
      {
         Student st1 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2011.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st2 = new Student("Petr", "Ivanovich", "Petrov", DateTime.ParseExact("2002.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st3 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2001.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st4 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2003.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st5 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2004.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st6 = new Student("Vasa", "Ivanovich", "Petrov", DateTime.ParseExact("2005.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);

         Teacher t1 = new Teacher("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("1950.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), "tpi", 2.5f, Degrees.Teacher);
         Teacher t2 = new Teacher("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("1959.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), "tpi", 2.5f, Degrees.Teacher);
         //Teacher t2 = new Teacher("Ivan", "Ivanovich", "Ivanon", new DateTime(), "tpi", 2.9f, Degrees.HeadOfDepartment);
         University Uni = new University();
         // Uni.Add(new Teacher("Ivan", "Ivanovich", "Ivanon", new DateTime(), "tpi", 2.9f, Degrees.HeadOfDepartment));
         Uni.Add(st5);
         Uni.Add(st6);
         Uni.Add(st1);
         Uni.Add(st2);
         Uni.Add(st3);
         var list = Uni.FindByLastName("Petrov");
         Uni.Remove(list.ElementAt(0));
         foreach(var l in list)
         {
            Console.WriteLine(l.ToString());
         }

         //Console.WriteLine("dfjalndkfjsafj \\");
         
         //Console.ReadLine();
         Console.WriteLine("Type 'help' for getting help");
         while (true)
         {
            
         }
      }
   }

}
