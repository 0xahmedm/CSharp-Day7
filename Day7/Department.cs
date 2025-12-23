using System;

namespace Day7
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            throw new NotImplementedException();
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,
            EmployeeLayOffEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
