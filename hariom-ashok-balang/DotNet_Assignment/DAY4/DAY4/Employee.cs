abstract class Employee
{
    public double BasicSalary;
    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BasicSalary + BasicSalary * 0.2;
    }
}

class PartTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BasicSalary;
    }
}

class ContractEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BasicSalary + 5000;
    }
}