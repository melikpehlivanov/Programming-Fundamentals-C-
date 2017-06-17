using System;

namespace Problem_3.Employee_Data
{
    class EmployeesData
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            decimal monthlySalary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Employee ID: " + $"{employeeID:D8}");
            Console.WriteLine("Salary: " + $"{monthlySalary:f2}");
        }
    }
}
