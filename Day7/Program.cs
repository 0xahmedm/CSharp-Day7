using System;
using Day7;

class Program
{
    static void Main()
    {
        // Create Department & Club
        Department dept = new Department
        {
            DeptID = 1,
            DeptName = "IT"
        };

        Club club = new Club
        {
            ClubID = 1,
            ClubName = "Company Club"
        };

        Console.WriteLine("=== NORMAL EMPLOYEE TEST ===");

        Employee emp1 = new Employee
        {
            EmployeeID = 101,
            BirthDate = new DateTime(1960, 1, 1), // age > 60
            VacationStock = 5
        };

        dept.AddStaff(emp1);
        club.AddMember(emp1);

        // Vacation test (will cause layoff)
        emp1.RequestVacation(DateTime.Today, DateTime.Today.AddDays(10));

        // Age test
        emp1.EndOfYearOperation();

        Console.WriteLine("\n=== SALES PERSON TEST ===");

        SalesPerson sales = new SalesPerson
        {
            EmployeeID = 202,
            BirthDate = new DateTime(1995, 1, 1),
            AchievedTarget = 40
        };

        dept.AddStaff(sales);
        club.AddMember(sales);

        // Fail target → layoff
        sales.CheckTarget(100);

        Console.WriteLine("\n=== BOARD MEMBER TEST ===");

        BoardMember board = new BoardMember
        {
            EmployeeID = 303,
            BirthDate = new DateTime(1940, 1, 1)
        };

        dept.AddStaff(board);
        club.AddMember(board);

        // Should NOT be fired by age
        board.EndOfYearOperation();

        // Fired only on resign
        board.Resign();

        Console.WriteLine("\n=== TEST COMPLETED ===");
    }
}
