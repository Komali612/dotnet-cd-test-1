using Xunit;

namespace DotnetService.Tests;

public class GreetingServiceTests
{
    private readonly GreetingService _service = new();

    [Fact]
    public void GreetsByName()
    {
        Assert.Equal("Hello, Komali!", _service.Greet("Komali"));
    }

    [Fact]
    public void DefaultsWhenNameMissing()
    {
        Assert.Equal("Hello, world!", _service.Greet(null));
        Assert.Equal("Hello, world!", _service.Greet("   "));
    }

    [Fact]
    public void TrimsWhitespace()
    {
        Assert.Equal("Hello, Ada!", _service.Greet("  Ada "));
    }
}
