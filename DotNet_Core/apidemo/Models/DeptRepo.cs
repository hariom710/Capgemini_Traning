namespace apidemo.Models;

public class DeptRepo : IDept
{
    AprdbContext context = new AprdbContext();

    public Dept AddDept(Dept dept)
    {
        context.Depts.Add(dept);
        context.SaveChanges();
        return dept;
    }

    public Dept? DeleteDept(int id)
    {
        var data = FindDept(id);
        if (data != null)
        {
            context.Depts.Remove(data);
            context.SaveChanges();
            return data;
        }

        return null;
    }

    public Dept? EditDept(Dept dept)
    {
        var data = FindDept(dept.Id);
        if (data != null)
        {
            data.Name = dept.Name;
            data.Location = dept.Location;
            context.SaveChanges();
            return data;
        }

        return null;
    }

    public Dept? FindDept(int id)
    {
        var data = (from d in context.Depts where d.Id == id select d).FirstOrDefault();
        return data;
    }

    public List<Dept> GetDepts()
    {
        var data = context.Depts.ToList();
        return data;
    }
}
