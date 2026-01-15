using Xunit;
using hello_world_api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace hello_world_api.Tests;

public class HelloControllerTests
{
    [Fact]
    public void Get_ReturnsExpectedString()
    {
        // Arrange
        var controller = new HelloController();

        // Act
        var result = controller.Get();

        // Assert
        Assert.Equal("Hello world!!!!!!", result);
        // here we have a unit test in place as part of the pipeline
    }
}
