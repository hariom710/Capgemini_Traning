using System;
using System.Collections.Generic;

namespace Day_2_Dotnet_Core_Backend_Assignment.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public string? Category { get; set; }
}
