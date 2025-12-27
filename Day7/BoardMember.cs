using System;

namespace Day7
{
    internal class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs
            {
                Cause = LayOffCause.Resigned
            });
        }

        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true;
        }

        public override void EndOfYearOperation()
        {
            // Do nothing
        }
    }
}
