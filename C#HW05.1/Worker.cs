

using System;

public partial class Worker
{
    private string firstName;
    public string FirstName { get; set; }

    private string lastName;
    public string LastName { get; set; }

    private string patronymic;
    public string Patronymic { get; set; }
    private int age;
    private decimal salary;
    private DateTime hireDate;

  

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be a positive integer.");
            age = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Salary must be a positive number.");
            salary = value;
        }
    }

    public DateTime HireDate
    {
        get { return hireDate; }
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Hire date cannot be in the future.");
            hireDate = value;
        }
    }

    public Worker(string firstName, string lastName, string patronymic, int age, decimal salary, DateTime hireDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Age = age;
        Salary = salary;
        HireDate = hireDate;
    }


    public override string ToString()
    {
        return $"{LastName} {FirstName} {Patronymic}, Age: {Age}, Salary: {Salary}, Hire Date: {HireDate.ToShortDateString()}";
    }
}
