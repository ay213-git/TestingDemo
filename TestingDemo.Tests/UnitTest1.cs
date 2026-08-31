namespace TestingDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Addition_ShouldReturnCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = a + b;

        // Assert
        Assert.Equal(8, result);
    }
}