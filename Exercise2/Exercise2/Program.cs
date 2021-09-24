using System;
using System.Collections.Generic;
using System.Globalization;

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
         Console.WriteLine(" [comand] --help  - manual for comand");
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
         if(s == "s")
         {
            Console.Write("Course: ");
            byte course =  byte.Parse(Console.ReadLine());
            Console.Write("Group: ");
            string group = Console.ReadLine();
            Console.Write("Averagescore: ");
            float averagescore = float.Parse(Console.ReadLine());
            uni.Add(new Student(name, patronomic, lastname, date, course, group, averagescore));
         }
         
         Console.Write("Date of birth: [yyyy.mm.dd]");
      }
      static void Main(string[] args)
      {
         Student st1 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2011.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st2 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2002.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st3 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2001.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st4 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2003.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st5 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2004.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         Student st6 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2005.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);

         Teacher t1 = new Teacher("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("1950.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), "tpi", 2.5f, Degrees.Teacher);
         Teacher t2 = new Teacher("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("1959.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), "tpi", 2.5f, Degrees.Teacher);
         //Teacher t2 = new Teacher("Ivan", "Ivanovich", "Ivanon", new DateTime(), "tpi", 2.9f, Degrees.HeadOfDepartment);
         University Uni = new University();
         // Uni.Add(new Teacher("Ivan", "Ivanovich", "Ivanon", new DateTime(), "tpi", 2.9f, Degrees.HeadOfDepartment));
         Uni.Add(t2);
         Uni.Add(t1);
         Uni.Add(st1);
         Uni.Add(st2);
         Uni.Add(st3);
         var list = Uni.Students;
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
