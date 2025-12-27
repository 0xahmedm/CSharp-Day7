using System;

namespace Day7
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = [];

        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
            ///Try Register for EmployeeLayOff Event Here
        }

        ///CallBackMethod  
        /// hy7sl eh lw 3mlt call tany with same employee
        /// if he doesn't unsubscribe?
        public void RemoveStaff(object sender,
       EmployeeLayOffEventArgs e)
        {
            Staff.Remove((Employee)sender);
            ((Employee)sender).EmployeeLayOff -= RemoveStaff;
        }
    }
}
