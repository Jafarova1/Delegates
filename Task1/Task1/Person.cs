using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
   public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }
        public Person(string PersonName,string PersonSurname,double PersonSalary,string PersonAdress)
        {
            Name = PersonName;
            Surname = PersonSurname;
            Salary = PersonSalary;
            Adress = PersonAdress;
            
        }
    }
}
