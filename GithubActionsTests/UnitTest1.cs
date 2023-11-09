namespace GithubActionsTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        const int number = 4;
        
        //Act

        var res = number + 1;

        //Assert
        
        Assert.Equal(4, res);
    }
}