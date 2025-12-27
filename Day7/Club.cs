using System;

namespace Day7
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        private List<Employee> Members = [];

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
            ///Try Register for EmployeeLayOff Event Here
        }

        ///CallBackMethod
        public void RemoveMember
       (object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.VacationStock)
            {
                Members.Remove((Employee)sender);
                ((Employee)sender).EmployeeLayOff -= RemoveMember;

            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
    }
}
