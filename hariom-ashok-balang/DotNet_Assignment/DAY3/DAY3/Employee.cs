class Employee
{
    public string Name;
    public double BasicSalary;

    public virtual double CalculateSalary()
    {
        return BasicSalary;
    }
}

class FullTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BasicSalary + (0.20 * BasicSalary);
    }
}

class PartTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BasicSalary;
    }
}