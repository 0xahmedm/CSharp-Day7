using System;

namespace Day7
{
    internal class Employee
    {
        public event
       EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff
       (EmployeeLayOffEventArgs e)
        {
            throw new NotImplementedException();
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public int VacationStock
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
        public void EndOfYearOperation()
        {
            throw new NotImplementedException();
        }
    }
}
