using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy.One_One
{
    internal class User_C
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Passport Passport { get; set; } //navigation property

    }
    class Passport
    {
        public int Id { get; set; }
        public string PassportNumber { get; set; }
        public int UserId { get; set; } //foreign key
        public User_C User { get; set; } //navigation property
    }
}
