using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercise2
{
   internal class Program
   {
      static University uni = new University();
      static void getHelp()
      {
         Console.WriteLine("Commands:\n add - adding person to University. Options -s adding a student; -t adding a teacher");
         Console.WriteLine(" revove [lastname] - removing person from University");
         Console.WriteLine(" find [option] [finding str] - searching people from University. Options -l finding by lastname; -d finding by department");
         Console.WriteLine(" list [options] - printing list of people from University. Options -s listing students; -t silting teachers; -p listing all");
         Console.WriteLine(" exit - exiting from program");
         Console.WriteLine(" help - printing this list");
        // Console.WriteLine(" [comand] --help  - manual for comand");
      }
      static void addPerson(string opt)
      {
         if(opt != "-s" && opt != "-t")
         {
            Console.WriteLine("Uncorrect option for add comand");
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
         if(opt == "t")
         {
            Console.Write("Department: ");
            string department =  Console.ReadLine();
            Console.Write("Seniority: ");
            float seniority = float.Parse(Console.ReadLine());
            Console.Write("Degree (1 - HeadOfDepartment, 2 - Professor, 3 - ProfessorAssistant, 4 - Teacher, 5 - LabAssistant): ");
            Degrees degree = (Degrees)byte.Parse(Console.ReadLine());
            uni.Add(new Teacher(name, patronomic, lastname, date, department, seniority, degree));
            Console.WriteLine("Teacher added successfuly");
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
            Console.WriteLine("Student added successfuly");
         }
      }
      static void remove(string lastname)
      {
         var rmlist = uni.FindByLastName(lastname);
         if(rmlist.Count() == 1)
         {
            uni.Remove(rmlist.First());
            return;
         }
         foreach (var l in rmlist)
            Console.WriteLine(l.ToString());
         Console.Write("Enter a number of person, who neet to remove");
         int i = Int32.Parse(Console.ReadLine());
         uni.Remove(rmlist.ElementAt(i - 1));
         Console.WriteLine("Person removed successfuly");
      }
      static void find(string opt, string s)
      {
         switch (opt)
         {
            case "-l":
               foreach (var p in uni.FindByLastName(s))
                  Console.WriteLine(p.ToString());
               break;
            case "-d":
               foreach (var p in uni.FindByDepartment(s))
                  Console.WriteLine(p.ToString());
               break;
            default:
               Console.WriteLine("Uncorrect option fot find command");
               break;
         }
      }
      static void list(string opt)
      {
         switch(opt)
         {
            case "-p":
               foreach (var p in uni.Persons)
                  Console.WriteLine(p.ToString());
               break;
            case "-s":
               foreach (var p in uni.Students)
                  Console.WriteLine(p.ToString());
               break;
            case "-t":
               foreach (var p in uni.Teachers)
                  Console.WriteLine(p.ToString());
               break;
            default:
               Console.WriteLine("Uncorrect option fot list command");
               break;
         }
      }
      static void Main(string[] args)
      {
         //Student st1 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2011.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         //Student st2 = new Student("Petr", "Ivanovich", "Petrov", DateTime.ParseExact("2002.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         //Student st3 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2001.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         //Student st4 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2003.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         //Student st5 = new Student("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("2004.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);
         //Student st6 = new Student("Vasa", "Ivanovich", "Petrov", DateTime.ParseExact("2005.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), 1, "pm11", 2.0);

         //Teacher t1 = new Teacher("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("1950.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), "tpi", 2.5f, Degrees.Teacher);
         //Teacher t2 = new Teacher("Ivan", "Ivanovich", "Ivanon", DateTime.ParseExact("1959.01.01", "yyyy.MM.dd", CultureInfo.InvariantCulture), "tpi", 2.5f, Degrees.Teacher);
         //Teacher t2 = new Teacher("Ivan", "Ivanovich", "Ivanon", new DateTime(), "tpi", 2.9f, Degrees.HeadOfDepartment);
         //University Uni = new University();
         // Uni.Add(new Teacher("Ivan", "Ivanovich", "Ivanon", new DateTime(), "tpi", 2.9f, Degrees.HeadOfDepartment));
         //Uni.Add(st5);
         //Uni.Add(st6);
         //Uni.Add(st1);
         //Uni.Add(st2);
         //Uni.Add(st3);
         //var list = Uni.FindByLastName("Petrov");
         //Uni.Remove(list.ElementAt(0));
         //foreach(var l in list)
         //{
         //   Console.WriteLine(l.ToString());
         //}

         //Console.WriteLine("dfjalndkfjsafj \\");
         
         //Console.ReadLine();
         Console.WriteLine("Type 'help' for getting help");
         bool flag = true;
         while (flag)
         {
            Console.Write("\nUniversity>");
            string s = Console.ReadLine();
            string[] str = s.Split();
            switch (str[0])
            {
               case "add":
                  if (str.Length > 1)
                     addPerson(str[1]);
                  else
                     Console.WriteLine("Uncorrect using remove command");
                  break;
               case "remove":
                  if (str.Length > 1)
                     remove(str[1]);
                  else
                     Console.WriteLine("Uncorrect using remove command");
                  break;
               case "find":
                  if (str.Length > 2)
                     find(str[1], str[2]);
                  else
                     Console.WriteLine("Uncorrect using find command");
                  break;
               case "list":
                  if (str.Length > 1)
                     list(str[1]);
                  else
                     Console.WriteLine("Uncorrect using list command");
                  break;
               case "help":
                  getHelp();
                  break;
               case "exit":
                  flag = false;
                  break;
               default:
                  Console.WriteLine("Uncorrect comand");
                  break;
            }

         }
      }
   }

}
