using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;
using StudentsAndWorkers.Interfaces;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
              var student = new Student("Gosho","Keremedchiiski",4);
              var worker = new Worker(200,5,"Petko","Keshko");
              Console.WriteLine(worker.MoneyPerHour(4));

              List<Student> students = new List<Student>
              {
                  new Student("Ivan","Bogomolkata",10),
                  new Student("Gosho","Tigura",10),
                  new Student("Petko","Luvut",9),
                  new Student("Grisho","Hipopotama",12),
                  new Student("Mitko","Kenguruto",5),
                  new Student("Georgi","Kobrata",7),
                  new Student("Mariq","Kotkata",4),
                  new Student("Stefka","Tigricata",3),
                  new Student("Sasho","Mishkata",8),
                  new Student("Maaikul","Oburkaaniq",12)
              };

              List<Worker> workers = new List<Worker>
              {
                  new Worker(200,4,"Pesho","Peshkata"),
                  new Worker(215,5,"Misho","Keremedchiski"),
                  new Worker(1000,4,"Gosho","Milionera"),
                  new Worker(300,7,"Mopcho","Programista"),
                  new Worker(600,5,"Edi","Dirigenta"),
                  new Worker(400,4,"Petko","Knijkata"),
                  new Worker(90,7,"Petko","Bednqka"),
                  new Worker(100,6,"Stoyan","Slunchogleda"),
                  new Worker(120,4,"Gosho","Birata"),
                  new Worker(170,5,"Mitko","Bezimenniq")
              };

              List<Worker> sortedWorkers = workers
                  .OrderByDescending(x=>x.MoneyPerHour(6)).ToList();

              List<Student> sortedStudents = students
                  .OrderBy(x=>x.Grade).ToList();

              for (int i=0;i<sortedWorkers.Count();i++)
              {
                  Console.WriteLine(sortedWorkers[i].FirstName);
                  Console.WriteLine(sortedWorkers[i].LastName);
                  Console.WriteLine(sortedWorkers[i].WeekSalary);
                  Console.WriteLine(sortedWorkers[i].WorkHoursPerDay);
                  Console.WriteLine(sortedWorkers[i].MoneyPerHour(6));
                  Console.WriteLine("-------------");
              }
              for (int i = 0; i < sortedStudents.Count(); i++)
              {
                  Console.WriteLine(sortedStudents[i].FirstName);
                  Console.WriteLine(sortedStudents[i].LastName);
                  Console.WriteLine(sortedStudents[i].Grade);
                  Console.WriteLine("-------------");
              }

              List<Human> people = new List<Human>();
              people.AddRange(students);
              people.AddRange(workers);

              var sortedPeople = from human in people
                                 orderby(human.FirstName)
                                 orderby(human.LastName)
                                 select human;
              foreach (var n in sortedPeople)
              {

                  Console.WriteLine(n.FirstName);
                  Console.WriteLine(n.LastName);
                  Console.WriteLine("******");
              } 
             
        }
    }
}
