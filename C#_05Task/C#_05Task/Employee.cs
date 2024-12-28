using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__05Task
{

   public enum LayOffCause
   {
       OverAge,
       UnderSEndck
   }

    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }

    internal class Employee
    {
        //Event
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        //Event Handler
        protected virtual void OnEmployeeLayOff (LayOffCause cause)
        {
            EmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs { Cause = cause });
        }



        public int EmployeeID { get; set; }

        public int _vacationStock;
        public DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
           
            set
            {
                _birthDate = value;
                int age = DateTime.Now.Year - _birthDate.Year;

        

                if (age >= 60)
                {
                    OnEmployeeLayOff(LayOffCause.OverAge);
                }
            }
        }

        public int vacationStock
        {
            get {return _vacationStock; }
            
            set {
                _vacationStock = value;
                if (_vacationStock<=0)
                {
                    OnEmployeeLayOff(LayOffCause.UnderSEndck);
                }
            
            }
        }

        public bool RequestVacation(DateTime Start, DateTime End)
        {
            int requestedDays = (End - Start).Days + 1;

            if (_vacationStock >= requestedDays)
            { 
                vacationStock -= requestedDays;
                return true;
            }

            return false; 
        }

        public void EndOfYearOperation()
        {
            _vacationStock += 5;
        }
    }
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int Quota)
        {
            return AchievedTarget >= Quota;
        }
    }

    class BoardMember : Employee
    {
        public void Resign()
        {
            Console.WriteLine($"Board member with ID: {EmployeeID} has resigned.");
        }
    }

}

