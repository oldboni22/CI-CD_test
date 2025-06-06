using Xunit;

namespace Tests;

public class Tests
{
    [Fact]
    public async Task Test1()
    {
        int a = 1;
        await Task.Delay(100);
        
        Assert.Equal(1,a);
        //
    }
}
