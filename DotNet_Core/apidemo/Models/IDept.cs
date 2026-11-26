namespace apidemo.Models;

public interface IDept
{
    List<Dept> GetDepts();
    Dept? FindDept(int id);
    Dept AddDept(Dept dept);
    Dept? EditDept(Dept dept);
    Dept? DeleteDept(int id);
}