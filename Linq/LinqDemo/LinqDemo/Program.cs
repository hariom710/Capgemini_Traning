

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DisplayFiles();
            // ReadFiles();
            //ProcessFile();
            //ListEmp();
            //SpecficCols();
            //SingleRecord();
                //Joins();
                //GroupBy();
            GroupData();

        }

        private static void GroupData()
        {
            Emp emp = new Emp();
            List<Emp> empList = emp.EmpList();
            Dept dept  = new Dept();
            var result = from e in empList group e by e.Dept into g select new { Dept = g.Key, Employees = g.ToList() };
            foreach (var group in result)
            {
                Console.WriteLine($"Department: {group.Dept}");
                foreach (var empInGroup in group.Employees)
                {
                    Console.WriteLine($"\tID: {empInGroup.Id}, Name: {empInGroup.Name}, Salary: {empInGroup.Salary}");
                }
            }

        }

        private static void GroupBy()
        {
            Emp emp = new Emp();
            List<Emp> empList = emp.EmpList();
            Dept dept=new Dept();
            List<Dept> deptList = dept.DeptList();
            var result = from e in empList 
                         join d in deptList on e.Dept equals d.Id group e by d.DeptName into Mygroup select new { DeptName = Mygroup.Key, Employees = Mygroup.ToList() };
        }

        //private static void Joins()
        //{
        //    Emp emp = new Emp();
        //    List<Emp> empList = emp.EmpList();
        //    //Dept dept = new Dept();
        //    //List<Dept> deptList = dept.DeptList();
        //    var result = from e in empList
        //                 join d in Dept.DeptList() on e.Dept equals d.DeptName
        //                 select new { e.Name, e.Salary, DeptName = d.DeptName, Location = d.Location };
        //}

        private static void SingleRecord()
        {
            int id = 2;
            Emp emp = new Emp();
            List<Emp> empList = emp.EmpList();
            var result = (from e in empList where e.Id == id select e).SingleOrDefault();
            if (result != null)
            {
                Console.WriteLine($"ID: {result.Id}, Name: {result.Name}, Salary: {result.Salary}, Dept: {result.Dept}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

        }

        private static void SpecficCols()
        {
            Emp emp = new Emp();
                        List<Emp> empList = emp.EmpList();
            var result = from e in empList select new { e.Name, e.Salary };
            foreach (var e in result)
            {
                Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}");
            }

        }

        private static void ListEmp()
        {
            Emp emp = new Emp();
            // var result = from e in empList select e;
            // var result = from e in empList where e.Salary > 50000 select e;
            // var result = from e in empList orderby e.Salary descending select e;
            // var result = from e in empList where e.Dept == "IT" select e;
            List<Emp> empList = emp.EmpList();
            var result =from e in empList select e;
            
            foreach (var e in result)
            {
                Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Salary: {e.Salary}, Dept: {e.Dept}");
            }
        }

        //private static void DisplayFiles()
        //{
        //    method syntax
        //    var files = Directory.GetFiles(@"D:\D drive backup\Claim Documents 2025", "*.*");
        //    linq syntax
        //    var files = from f in Directory.GetFiles(@"C:\Users\Hp\OneDrive\Documents\Resume", "*.*") select f;
        //    foreach (var file in files)
        //    {
        //        Console.WriteLine(file);
        //    }
        //}

        //public static void ReadFiles()
        //{
        //    string fname = "emp.dat";
        //    // var lines = File.ReadAllLines(fname);
        //    var lines = from l in File.ReadAllLines(fname).Skip(1) select l;
        //    foreach (var line in lines)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}

        private static void ProcessFile()
        {
            string fname = "emp.dat";
            string filePath = Path.Combine(AppContext.BaseDirectory, @"..\..\..", fname);

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found at: {Path.GetFullPath(filePath)}");
                return;
            }

            var lines = from l in File.ReadAllLines(filePath).Skip(1) select l;
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                Console.WriteLine($"ID: {parts[0]}, Name: {parts[1]}, Salary: {parts[2]}, Dept: {parts[3]}");
            }
        }
    }
}
