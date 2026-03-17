using System;

class Employee
{
    int employeeId;
    string name;
    decimal salary;

    // Default constructor
    public Employee()
    {
        employeeId = 0;
        name = "";
        salary = 0;
    }

    // Parameterized constructor
    public Employee(int id, string empName, decimal empSalary)
    {
        employeeId = id;
        name = empName;
        salary = empSalary;
    }

    // Method to calculate annual salary
    public decimal CalculateAnnualSalary()
    {
        return salary * 12;
    }

    // Method to display employee information
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {employeeId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Monthly Salary: ${salary:F2}");
        Console.WriteLine($"Annual Salary: ${CalculateAnnualSalary():F2}");
    }

    // Main method for entry point
    static void Main(string[] args)
    {
        // Create employee objects using default constructor
        Employee emp1 = new Employee();
        emp1.employeeId = 101;
        emp1.name = "Devgang Patel";
        emp1.salary = 5000.00m;

        // Create employee objects using parameterized constructor
        Employee emp2 = new Employee(102, "Rajat Yadav", 6000.00m);

        // Display employee information
        Console.WriteLine("Employee 1 Information:");
        emp1.DisplayEmployeeInfo();
        Console.WriteLine();

        Console.WriteLine("Employee 2 Information:");
        emp2.DisplayEmployeeInfo();
    }
}