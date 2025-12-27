using System;
using System.Net.Http.Headers;

namespace Day7
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.FailTarget
                });
                return false;
            }
            return true;
        }

        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true;
        }
    }
}
