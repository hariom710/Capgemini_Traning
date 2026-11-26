using System;
using System.Collections.Generic;

namespace Day_2_Dotnet_Core_Backend_Assignment.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public double? Salary { get; set; }
}
