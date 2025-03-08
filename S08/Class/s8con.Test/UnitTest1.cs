namespace s8con.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int x = 1;
        Assert.Equal(x+1,2);
    }
    public void Test2()
    {
        int result = Program.add(3,5);
        Assert.Equal(result,8);
    }
}
