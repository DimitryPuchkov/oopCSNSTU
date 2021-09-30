using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercise2
{
   internal class Program
   {
      static University uni = new University();
      static void getHelp()
      {
         Console.WriteLine("Commands:\n add - adding person to University. Options -s adding a student; -t adding a teacher");
         Console.WriteLine(" remove [lastname] - removing person from University");
         Console.WriteLine(" find [option] [finding str] - searching people from University. Options -l finding by lastname; -d finding by department");
         Console.WriteLine(" list [options] - printing list of people from University. Options -s listing students; -t silting teachers; -p listing all");
         Console.WriteLine(" sort [option] - a: ascending or d: descending");
         Console.WriteLine(" exit - exiting from program");
         Console.WriteLine(" help - printing this list");
      }
      static void addPerson(string opt)
      {
         if (opt != "-s" && opt != "-t")
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
         if (opt == "-t")
         {
            Console.Write("Department: ");
            string department = Console.ReadLine();
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
         if (rmlist.Count() == 1)
         {
            uni.Remove(rmlist.First());
            Console.WriteLine("Person removed successfuly");
            return;
         }
         foreach (var l in rmlist)
            Console.WriteLine(l.ToString());
         Console.Write("Enter a number of person, who need to remove: ");
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
         switch (opt)
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
         string[] lines = File.ReadAllLines("file.txt");
         string[] data;
         for (int i = 0; i < lines.Length; i++)
         {
            data = lines[i].Split();
            if (int.TryParse(data[4], out int _))
               uni.Add(Student.Parse(lines[i]));
            else
               uni.Add(Teacher.Parse(lines[i]));
         }

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
               case "sort":
                  if (str[1] == "a")
                     uni.SortMode = false;
                  else if (str[1] == "d")
                     uni.SortMode = true;
                  else
                     Console.WriteLine("Uncorrect comand");
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

