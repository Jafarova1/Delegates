using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Employee emp1 = new Employee(18, 150);
            Employee emp2 = new Employee(35, 110);
            Employee emp3 = new Employee(22, 100);
            Employee emp4 = new Employee(38, 200);
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            Console.WriteLine(CalculateSalary(CheckEmployee,list));
        }
        public static bool CheckEmployee(int age)
        {
            return age > 20 && age < 40;
        }
        public static int CalculateSalary(Predicate<int> predicate,List<Employee> list)    
        {
            int sum = 0;
            foreach (var item in list)
            {
                if (predicate(item.Age))
                {
                    sum += item.Salary;
                }
            }
            return sum / 2;
        }
    }
}
