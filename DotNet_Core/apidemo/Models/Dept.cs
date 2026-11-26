using System;
using System.Collections.Generic;

namespace apidemo.Models;

public partial class Dept
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
