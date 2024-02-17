// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge
/*
common to every employee:
property: ID (req, int) init only
property: Department (req, str) modifiable
property: Full Name (req, str) modifiable
Method: AdjustPay(decimal percentage) increase pay by a certain percentage amount

Hourly employee
property: PayRate(decimal)

Salaried employee
property: Salary(decimal)
*/
using System.ComponentModel;
using System.Data.Common;

public class Employee
{
    private readonly int _id;
    public Employee() { }

    public Employee(string fullName, string department, int id)
    {
        ID = id;
        Department = department;
        FullName = fullName;
    }

    // YOUR CODE GOES HERE
    public required int ID
    {
        get => _id;
        init => _id = value;
    }
    public required string Department { get; set; }
    public required string FullName { get; set; }

    public decimal Pay { get; set; }

    public override string ToString() => $"{ID}:{FullName}, {Department} ";

    public virtual void AdjustPay(decimal percentage) { }
}

// DEFINE OTHER CLASSES HERE
public class SalariedEmployee : Employee
{
    public SalariedEmployee() { }
    public SalariedEmployee(string fullName, string department, int id, decimal salary)
        : base(fullName, department, id)
    {
        Salary = salary;
    }

    public decimal Salary { get; set; }

    public override void AdjustPay(decimal percentage)
    {
        Salary += Salary * percentage;
    }
}

public class HourlyEmployee : Employee
{
    public HourlyEmployee() { }
    public HourlyEmployee(string fullName, string department, int id, decimal payRate)
        : base(fullName, department, id)
    {
        PayRate = payRate;
    }

    public decimal PayRate { get; set; }

    public override void AdjustPay(decimal percentage)
    {
        PayRate += PayRate * percentage;
    }
}
