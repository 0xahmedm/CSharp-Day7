using System;

namespace Day7
{
    public enum LayOffCause
    {
        VacationStock,
        AgeOver60,
        FailTarget,
        Resigned
    }

    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
