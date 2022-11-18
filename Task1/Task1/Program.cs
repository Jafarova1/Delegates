using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Gultaj", "Jafarova", 900, "Elmler");
            Person person2 = new Person("Fidan", "Hesenova", 1650, "Nizami");
            Person person3 = new Person("Meryem", "Osmanova", 1570, "Ehmedli");
            Person person4 = new Person("Esmer", "Cabbarova", 1000, "Ecemi");
            List<Person> person = new List<Person>();
            person.Add(person1);
            person.Add(person2);
            person.Add(person3);
            person.Add(person4);
           

            ShowPeople(CheckSalary, person);



        }

        public static bool CheckSalary(double salary)
        {
            return salary > 1000;
            
            
                   

        }
        public static void ShowPeople(Predicate<double> predicate, List<Person> person)
        {

            foreach (var item in person)
            {
                if (predicate(item.Salary))
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Adress}");
                }
            }
            
            
          
        }
    }
}
