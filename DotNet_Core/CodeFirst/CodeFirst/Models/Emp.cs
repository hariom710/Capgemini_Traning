using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    [Index(nameof(EMail), IsUnique = true)]
    internal class Emp
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public int Salary { get; set; }
        [StringLength(50)]
        // Navigation property
        public string?EMail { get; set; }
        [ForeignKey("Dept")]
        public int DeptId { get; set; }

        public Dept? Dept { get; set; }
    }
}
