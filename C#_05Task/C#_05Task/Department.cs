using C__05Task;
using System;
using System.Collections.Generic;

internal class Department
{
    public int DeptID { get; set; }
    public string DeptName { get; set; }

    private List<Employee> Staff;

    public Department(int _DepID, string _DeptName)
    {
        DeptID = _DepID;
        DeptName = _DeptName;
        Staff = new List<Employee>();
    }

    public void AddStaff(Employee E)
    {
        if (E != null)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;

            string role = E is SalesPerson ? "SalesPerson" : E is BoardMember ? "BoardMember" : "Employee";
            Console.WriteLine($"Staff member ({role}) with ID: {E.EmployeeID} has been added to the department: {DeptName}");
            Console.WriteLine("=================================================");
        }
    }

    public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
    {
        Employee emp = sender as Employee;

        if (emp != null)
        {
            string role = emp is SalesPerson ? "SalesPerson" : emp is BoardMember ? "BoardMember" : "Employee";
            Console.WriteLine($"Employee ({role}) with ID: {emp.EmployeeID}, Birth Date: {emp.BirthDate}, " +
                              $"and Vacation Stock: {emp.vacationStock} is being removed due to: {e.Cause}");
            Console.WriteLine("=================================================");

            emp.EmployeeLayOff -= RemoveStaff;
            Staff.Remove(emp);
        }
    }

}
