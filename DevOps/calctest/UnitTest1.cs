using Calc;
namespace calctest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 5;
        int b = 10;
        int expected = 15;
        int result = Calc.Program.Add2Numbers(a, b);
        Assert.Equal(expected, result);
    }
}
