using System;

namespace Day7
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff
       (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
            Console.WriteLine($"Employee {EmployeeID}" +
                $" laid off due to {e.Cause}");
        }

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        public virtual bool RequestVacation(DateTime From, DateTime To)
        {
            int daysRequested = (To - From).Days + 1;
            VacationStock -= daysRequested;
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.VacationStock
                });
            }
            else
            {
                return true;
            }
            return false;
        }
        public virtual void EndOfYearOperation()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (today < BirthDate.AddYears(age)) age--;

            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.AgeOver60
                });
            }
        }
    }
}