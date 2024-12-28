using System;
using System.Collections.Generic;

namespace C__05Task
{
    internal class Club
    {
        public string ClubName { get; set; }

        private List<Employee> Members;

        public Club(string clubName)
        {
            ClubName = clubName;
            Members = new List<Employee>();
        }

        public void AddMember(Employee E)
        {
            if (E != null)
            {
                Members.Add(E);
                E.EmployeeLayOff += RemoveMember;

                string role = E is SalesPerson ? "SalesPerson" : E is BoardMember ? "BoardMember" : "Member";
                Console.WriteLine($"Member ({role}) with ID: {E.EmployeeID} has been added to the club: {ClubName}");
                Console.WriteLine("=================================================");
            }
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = sender as Employee;

            if (emp != null)
            {
                string role = emp is SalesPerson ? "SalesPerson" : emp is BoardMember ? "BoardMember" : "Member";
                Console.WriteLine($"Club Member ({role}) with ID: {emp.EmployeeID}, Birth Date: {emp.BirthDate}, " +
                                  $"and Vacation Stock: {emp.vacationStock} is being removed due to: {e.Cause}");
                Console.WriteLine("=================================================");

                emp.EmployeeLayOff -= RemoveMember;
                Members.Remove(emp);
            }
        }

    }
}
