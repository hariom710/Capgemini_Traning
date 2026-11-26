using System;
using System.Collections.Generic;

namespace apidemo.Models;

public partial class Emp
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Salary { get; set; }

    public string? Email { get; set; }

    public int DeptId { get; set; }

    public virtual Dept Dept { get; set; } = null!;
}
