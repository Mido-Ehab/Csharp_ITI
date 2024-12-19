using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
   
    public class Employee :IComparable
    {
        public int ID;
        public double salary;
        public Gender gender;
        public hiringDate hiringDate;
        public string name;
        public SecurityLevel securityLevel;
        public int Age;
        public int Target;

        public Employee()
        {
            ID = 0;
            salary = 0.0;
            gender = Gender.Male;
            hiringDate = new hiringDate();
            name = "empty";
            securityLevel = SecurityLevel.Admin;
            Age = 18;
            Target = 300;
        }

        public Employee(int id, double _salary, Gender _gender, hiringDate _hiringDate, string _name,SecurityLevel _securityLevel, int _age, int _target)
        {
            ID = id;
            salary = _salary;
            gender = _gender;
            hiringDate = _hiringDate;
            name = _name;
            securityLevel = _securityLevel;
            Age = _age;
            Target = _target;
        }

        //-----------------------------------------ID
        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        //-----------------------------------Salary
        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double _salary)
        {
            salary = _salary;
        }

        //-----------------------------------Genders
        public Gender GetGender()
        {
            return gender;
        }

        public void SetGender(Gender _gender)
        {
            gender = _gender;
        }

        // ---------------------------------Hire date
        //public hiringDate GetHiringDate()
        //{
        //    return hiringDate;
        //}

        //public void SetHiringDate(hiringDate _hiringDate)
        //{
        //    hiringDate = _hiringDate;
        //}

        //-------------------------------------name
        public string GetName()
        {
            return name;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        //------------------------------------Security Level
        public SecurityLevel GetSecurity()
        {
            return securityLevel; 
        }

        public void SetSecurity(SecurityLevel _security)
        {
            securityLevel = _security;
        }

        //-----------------------------------Age
        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int _age)
        {
            if (Age <=18 && 45 >= Age) 
            { 
            Age = _age;
            }
        }

        //----------------------------------Target
        public int GetTarget()
        {

            return Target;
        }

        public void SetTarget(int _target)
        {
            if (300 <= Target)
            {
                Target = _target;
            }
        }


        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj; //as | is
            if (hiringDate.day > e.hiringDate.day)
                return 1;
            else if (hiringDate.day < e.hiringDate.day)
                return -1;
            else
                return 0;


            if (hiringDate.month > e.hiringDate.month)
                return 1;
            else if (hiringDate.month < e.hiringDate.month)
                return -1;
            else
                return 0;

            if (hiringDate.year > e.hiringDate.year)
                return 1;
            else if (hiringDate.year < e.hiringDate.year)
                return -1;
            else
                return 0;


        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Hiring Date: {hiringDate.GetDate()}");
            Console.WriteLine($"SecurityLevel: {GetSecurity()}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Target: {Target}");
        }
    }
}







/*
public override string ToString()
 {
     return $"Id :{Id}  Name: {Name} , age {age} ,target {target},salary {salary}, Gender {Gender},hiringDate :{HiringDate.Day}/{HiringDate.Month}/{HiringDate.Year},securityLevel {SecurityLevel} ";
 }
*/