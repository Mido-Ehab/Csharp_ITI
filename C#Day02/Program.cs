using System;
using System.Reflection;
using  Day02;

namespace C_Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int employeeCount = int.Parse(Console.ReadLine());


            //----------------------------------------------------Array of employee
            Employee[] employees = new Employee[employeeCount];

            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"\nEntering data for Employee {i + 1}:");

                //---------------------------------------------------ID
                Console.Write("Enter Employee ID: ");
                int id = int.Parse(Console.ReadLine());

                // --------------------------------------------------Name
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                //----------------------------------------------------Gender
                Console.Write("Enter Gender (Male/Female): ");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

                // ----------------------------------------------------salary
                Console.Write("Enter Employee Salary: ");
                double salary = double.Parse(Console.ReadLine());

                // ----------------------------------------------------Hiring
                Console.WriteLine("Enter Hiring Date:");
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
                hiringDate hireDate = new hiringDate(year, month, day);

                //----------------------------------------------------------Security Level
                Console.WriteLine("Enter Security Level : ");
                Enum.TryParse(Console.ReadLine(),true,out SecurityLevel securityLevel);
                securityLevel = SecurityLevel.Admin;

                //---------------------------------------------------------Age
                Console.WriteLine("Enter the Age : ");
                int age = int.Parse(Console.ReadLine());

                //---------------------------------------------------------Target
                Console.WriteLine("Enter the Target : ");
                int target = int.Parse(Console.ReadLine());

                employees[i] = new Employee(id, salary, gender, hireDate, name,securityLevel,age,target);
            }


            Array.Sort(employees);

            // ---------------------------------------------Display
            Console.WriteLine("\nEmployee Details:");
            foreach (var employee in employees)
            {
                employee.DisplayEmployeeInfo();
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
    }
}
