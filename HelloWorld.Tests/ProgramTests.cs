namespace HelloWorld.Tests;

public class ProgramTests
{
    [Fact]
    public void GetGreeting_ShouldReturn_HelloWorld()
    {
        // Act
        var result = Program.GetGreeting();

        // Assert
        Assert.Equal("Hello, World!", result);
    }
}
